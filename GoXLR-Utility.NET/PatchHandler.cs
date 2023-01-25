using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums;
using GoXLR_Utility.NET.Models;
using GoXLR_Utility.NET.Models.Response.Patch;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks.Sample;

namespace GoXLR_Utility.NET
{
    public class PatchHandler
    {
        private readonly PatchCache _patchCache = new PatchCache();
        private static JsonSerializerOptions _serializerOptions;
   
#if DEBUG
        private readonly Stopwatch _debugWatch = new Stopwatch();
#endif
        
        public PatchHandler(JsonSerializerOptions serializerOptions)
        {
            _serializerOptions = serializerOptions;
        }
        
        /// <summary>
        /// Handle an Array of Patches
        /// </summary>
        /// <param name="parentClass">The class where the Patch should be applied</param>
        /// <param name="patches">The Array of patches</param>
        public void HandlePatch(object parentClass, params Patch[] patches)
        {
#if DEBUG
            _debugWatch.Start();
#endif
            foreach (var patch in patches)
            {
                try
                {
                    HandlePatch(parentClass, patch);
                }
                catch (Exception e)
                {
                    //TODO Log every exception thrown by the Patch Handler
                    Console.WriteLine(e);
                }
            }
#if DEBUG     
            _debugWatch.Stop();
            double  ticks = _debugWatch.ElapsedTicks;
            var seconds = ticks / Stopwatch.Frequency;
            var milliseconds = (ticks / Stopwatch.Frequency) * 1000;
            var nanoseconds = (ticks / Stopwatch.Frequency) * 1000000000;
            Console.WriteLine($"s: {seconds} | ms: {milliseconds} | ns: {nanoseconds} | t: {ticks}");
            _debugWatch.Reset();
#endif
        }

        /// <summary>
        /// Handle single Patches
        /// </summary>
        /// <param name="parentClass">The class where the Patch should be applied</param>
        /// <param name="patch">The Patch that should be applied</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void HandlePatch(object parentClass, Patch patch)
        {
            //Return if parentClass hasn't been initialized after connection
            if (parentClass is null)
                return;

            CreatePathSegments(patch.Path, out var pathSegments, out var lastIndex, out var filePath);

            if (!CheckCache(patch.Path, out var patchCacheItem))
            {
                patchCacheItem = CacheNewPatches(patch.Path, parentClass, pathSegments);
            }

            //Indicates that a GoXLR has been connected or removed
            if (PatchDeviceConnection(patch, patchCacheItem))
                return;
            
            //In case propType or myClass is null, the path could be not implemented yet. 
            if (patchCacheItem.PropType is null || parentClass is null)
                throw new ArgumentOutOfRangeException($"Path not implemented: {patch.Path}");
            
            var genericType = GetGenericType(patchCacheItem.PropType, out var genType);
            switch (genericType)
            {
                case GenericTypeEnum.NonGeneric:
                    PatchNonGeneric(patch, patchCacheItem);
                    break;
                
                case GenericTypeEnum.List:
                    PatchGenericList(patch, patchCacheItem, lastIndex);
                    break;
                
                case GenericTypeEnum.Dictionary:
                    PatchGenericDictionary(patch, patchCacheItem, filePath);
                    break;

                case GenericTypeEnum.Other:
                default:
                    throw new ArgumentOutOfRangeException($"{genType} is Generic but maybe isn't implemented");
            }
        }
        
        /// <summary>
        /// Create Path Segments from the given Patch
        /// </summary>
        /// <param name="path">The Path of the Patch</param>
        /// <param name="pathSegments">The created Path Segments</param>
        /// <param name="lastIndex">The Index if a List has been manipulated</param>
        /// <param name="filePath">The FilePath if a File has been manipulated</param>
        private void CreatePathSegments(string path, out string[] pathSegments, out int lastIndex, out string filePath)
        {
            //Split the Path in Segments
            pathSegments = path.Split(new []{'/'}, StringSplitOptions.RemoveEmptyEntries);

            //Check if last segment is a number, this would indicate a manipulation on a List so we remove it.
            if (int.TryParse(pathSegments.Last(), out lastIndex))
                Array.Resize(ref pathSegments, pathSegments.Length - 1);
            
            //Check if last segment is a filePath
            if (TryParseFile(pathSegments, out filePath))
                Array.Resize(ref pathSegments, pathSegments.Length - 1);
        }

        /// <summary>
        /// Check if the Patch Path is already in the Cache for faster access
        /// </summary>
        /// <param name="path">The Patch</param>
        /// <param name="item">The found PatchCacheItem</param>
        /// <returns>If it has been found in the Cache</returns>
        private bool CheckCache(string path, out PatchCacheItem item)
        {
            if (!_patchCache.TryGetValue(path, out var cacheItem))
            {
                item = default;
                return false;
            }

            item = cacheItem;
            return true;
        }
        
        /// <summary>
        /// Traverse the Class and return a new PatchCacheItem
        /// </summary>
        /// <param name="fullPath">The Path as String</param>
        /// <param name="parentClass">The parentClass</param>
        /// <param name="pathSegments">The Segments of the Path</param>
        /// <returns>Created PatchCacheItem</returns>
        private PatchCacheItem CacheNewPatches(string fullPath, object parentClass, string[] pathSegments)
        {
            var patchCacheItem = new PatchCacheItem(parentClass, pathSegments);
            var pathAsClasses = new List<object>{ parentClass };

            var shouldBeCached = true;
            var type = parentClass.GetType();
            var lastSegment = patchCacheItem.PathSegments.Last();

            //Traverse Properties:
            foreach (var path in pathSegments)
            {
                if (path == lastSegment)
                    break;

                if (type == typeof(Dictionary<string, Device>))
                {
                    patchCacheItem.SerialNumber = path;
                    
                    //Get value of Device Dictionary with given SerialNumber
                    patchCacheItem.ParentClass = type.GetProperty("Item")?.GetValue(patchCacheItem.ParentClass, new object[] { path });
                }
                else if (type == typeof(List<Sample>) && int.TryParse(path, out var index)
                                                      && ((IList)patchCacheItem.ParentClass).Count >= index)
                {
                    //Skip caching since the List isn't the final type to
                    //avoid using an old cache after this list has been changed
                    shouldBeCached = false;
                    patchCacheItem.ParentClass = ((IList)patchCacheItem.ParentClass)[index];
                }
                else
                {
                    patchCacheItem.ParentClass = GetPropertyInfo(type, path)?.GetValue(patchCacheItem.ParentClass);
                }

                pathAsClasses.Add(patchCacheItem.ParentClass);
                type = patchCacheItem.ParentClass?.GetType();
            }

            //Set value:
            patchCacheItem.PropInfo = GetPropertyInfo(type, lastSegment);
            patchCacheItem.PropType = patchCacheItem.PropInfo?.PropertyType;
            patchCacheItem.PathAsClasses = pathAsClasses;

            if (shouldBeCached)
                _patchCache.TryAdd(fullPath, patchCacheItem);

            return patchCacheItem;
        }

        /// <summary>
        /// Check which type of Generic the Property is
        /// In case it isn't Generic its "Other"
        /// </summary>
        /// <param name="propType">The PropertyType</param>
        /// <param name="genericType">The parsed generic Type</param>
        /// <returns>A GenericTypeEnum indication what it is</returns>
        private GenericTypeEnum GetGenericType(Type propType, out Type genericType)
        {
            genericType = default;
            if (!propType.IsGenericType)
                return GenericTypeEnum.NonGeneric;

            genericType = propType.GetGenericTypeDefinition();
            if (genericType == typeof(List<>))
            {
                return GenericTypeEnum.List;
            }

            if (genericType == typeof(Dictionary<,>))
            {
                return GenericTypeEnum.Dictionary;
            }

            return GenericTypeEnum.Other;
        }
        
        /// <summary>
        /// Gets the PropertyInfo where the JsonPropertyName or the default PropertyName
        /// matches the given PathSegment
        /// </summary>
        /// <param name="type">Type where to search for the segment</param>
        /// <param name="pathSegment">Segment to search for</param>
        /// <returns>The found PropertyInfo</returns>
        private PropertyInfo GetPropertyInfo(Type type, string pathSegment)
        {
            if (type is null)
                return null;

            foreach (var propertyInfo in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                //Match on exact name from JsonPropertyName:
                if (propertyInfo.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name == pathSegment)
                    return propertyInfo;

                //Or match from segment to property name, cleaned for snake_case to camelCase with ignore case:
                if (propertyInfo.Name.Equals(pathSegment.Replace("_", ""), StringComparison.OrdinalIgnoreCase))
                    return propertyInfo;
            }

            return null;
        }

        /// <summary>
        /// Patch non Generic Items
        /// </summary>
        /// <param name="patch">The patch that should be applied</param>
        /// <param name="patchCacheItem">The cached Item</param>
        /// <exception cref="JsonException"></exception>
        private void PatchNonGeneric(Patch patch, PatchCacheItem patchCacheItem)
        {
            //If the Deserialization throws, there could be a problem with the Models
            object value;
            try
            {
                value = patch.Value.Deserialize(patchCacheItem.PropType, _serializerOptions);
            }
            catch
            {
                throw new JsonException($"Couldn't deserialize '{patch.Value}' to {patchCacheItem.PropType.Name} ({patch.Path}).");
            }
            patchCacheItem.PropInfo.SetValue(patchCacheItem.ParentClass, value);
        }

        /// <summary>
        /// Patch a Generic List
        /// </summary>
        /// <param name="patch">The patch that should be applied</param>
        /// <param name="patchCacheItem">The cached Item</param>
        /// <param name="lastIndex">The index that should be manipulated</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void PatchGenericList(Patch patch, PatchCacheItem patchCacheItem, int lastIndex)
        {
            //Since we know the Generic Type is a List, use it to cast to IList and manipulate it.
            var array = (IList)patchCacheItem.PropInfo.GetValue(patchCacheItem.ParentClass);
            object value;
            switch (patch.Op)
            {
                case OpPatchEnum.Remove:
                    lock (array) //Lock the array to safely manipulate it
                    {
                        array.RemoveAt(lastIndex);
                    }

                    break;

                case OpPatchEnum.Add:
                    lock (array)
                    {
                        value = GetListValue(patchCacheItem.PropType, patch.Value);
                        array.Add(value);
                    }

                    break;

                case OpPatchEnum.Replace:
                    lock (array)
                    {
                        value = GetListValue(patchCacheItem.PropType, patch.Value);
                        array[lastIndex] = value;
                    }

                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        $"{patch.Op} not implemented for {patchCacheItem.PropType.BaseType}");
            }
        }

        /// <summary>
        /// Patch a Generic Dictionary (Only File Paths)
        /// </summary>
        /// <param name="patch">The patch that should be applied</param>
        /// <param name="patchCacheItem">The cached Item</param>
        /// <param name="filePath">The Filepath</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void PatchGenericDictionary(Patch patch, PatchCacheItem patchCacheItem, string filePath)
        {
            if (patchCacheItem.PropType.GetGenericArguments().FirstOrDefault() != typeof(string))
                throw new ArgumentOutOfRangeException($"{patchCacheItem.PropType.Name} is a Dictionary<T, S> but T, S maybe isn't implemented");
                
            //Since we know the Generic Type is a Dictionary, use it to cast to Dictionary and manipulate it.
            var dictionary = (IDictionary)patchCacheItem.PropInfo.GetValue(patchCacheItem.ParentClass);
                
            //Split the File Name from its path
            var splitPath = filePath.Split('/', '\\');
            var value = splitPath[splitPath.Length - 1];
            switch (patch.Op)
            {
                case OpPatchEnum.Remove:
                    lock (dictionary)
                    {
                        dictionary.Remove(filePath);
                    }
                    break;
                    
                case OpPatchEnum.Add:
                    lock (dictionary)
                    {
                        dictionary.Add(filePath, value);
                    }
                    break;
                        
                case OpPatchEnum.Replace: //TODO Maybe this isn't even needed
                    lock (dictionary)
                    {
                        dictionary[filePath] = value;
                    }
                    break;
                    
                default:
                    throw new ArgumentOutOfRangeException($"{patch.Op} not implemented for {patchCacheItem.PropType.BaseType}"); 
            }
        }
        
        /// <summary>
        /// Check if its a Device connection or disconnection and patch it
        /// </summary>
        /// <param name="patch">The patch that should be applied</param>
        /// <param name="patchCacheItem">The cached Item</param>
        /// <returns>A bool indication if its a Device Patch or not</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private bool PatchDeviceConnection(Patch patch, PatchCacheItem patchCacheItem)
        {
            //Indicates that a GoXLR has been connected or removed
            if (!(patchCacheItem.PropType is null &&
                  patchCacheItem.PathSegments.Length == 2 &&
                  patchCacheItem.SerialNumber != null))
                return false;

            var dictionary = (IDictionary) patchCacheItem.ParentClass;
            if (dictionary is null)
                throw new ArgumentNullException(nameof(patch), "HandleDeviceConnection | Dictionary is null");

            switch (patch.Op)
            {
                case OpPatchEnum.Add:
                    var value = patch.Value.Deserialize<Device>(_serializerOptions);
                    lock (dictionary)
                    {
                        dictionary.Add(patchCacheItem.SerialNumber, value);
                    }
                    break;
                
                case OpPatchEnum.Remove:
                    lock (dictionary)
                    {
                        dictionary.Remove(patchCacheItem.SerialNumber);
                    }
                    break;

                case OpPatchEnum.Replace:
                default:
                    throw new ArgumentOutOfRangeException($"{patch.Op} not implemented for manipulating the Device Dictionary");
            }
            return true;
        }

        /// <summary>
        /// Retrieve the Values of a List via deserialization
        /// </summary>
        /// <param name="type">Type that is a List</param>
        /// <param name="value">The JsonNode that should be deserialized</param>
        /// <returns>The List as object</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private object GetListValue(Type type, JsonNode value)
        {
            //To deserialize it we need the to get the base class which the List uses.
            var genArg = type.GetGenericArguments().FirstOrDefault();
            if (genArg is null)
                throw new ArgumentNullException($"ElementType of {type} is null");

            return value.Deserialize(genArg, _serializerOptions);
        }

        private bool TryParseFile(IReadOnlyList<string> segments, out string fileName)
        {
            fileName = default;
            
            if (segments.Count <= 1)
                return false;

            var isPresent = segments[segments.Count - 2];

            if (!isPresent.Equals("samples"))
                return false;

            fileName = segments[segments.Count - 1];
            return true;
        }
    }
}