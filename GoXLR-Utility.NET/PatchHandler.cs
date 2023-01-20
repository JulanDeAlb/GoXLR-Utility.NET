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
using GoXLR_Utility.NET.Models.Patch;
using GoXLR_Utility.NET.Models.Response.Status.Config;
using GoXLR_Utility.NET.Models.Response.Status.Files;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.ButtonDown;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.CoughButton;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.PresetNames;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Volumes;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Gain;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.MicGains;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.NoiseGate;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Router;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks.Sample;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Settings;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Settings.GuiDisplay;
using GoXLR_Utility.NET.Models.Response.Status.Paths;

namespace GoXLR_Utility.NET
{
    public class PatchHandler
    {
        private readonly Events.Events _events;
        private readonly PatchCache _patchCache = new PatchCache();
        private static JsonSerializerOptions _serializerOptions;
        private readonly Stopwatch _s = new Stopwatch();

        public bool ShouldInvokeEvents = true;
        
        public PatchHandler(Events.Events events, JsonSerializerOptions serializerOptions)
        {
            _events = events;
            _serializerOptions = serializerOptions;
        }
        
        public void HandlePatch(object parentClass, params Patch[] patches)
        {
            _s.Start();
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
            
            _s.Stop();
            double  ticks = _s.ElapsedTicks;
            double  seconds = ticks / Stopwatch.Frequency;
            double  milliseconds = (ticks / Stopwatch.Frequency) * 1000;
            double  nanoseconds = (ticks / Stopwatch.Frequency) * 1000000000;
            Console.WriteLine($"s: {seconds} | ms: {milliseconds} | ns: {nanoseconds} | t: {ticks} | ");
            _s.Reset();
        }

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
            if (PatchDeviceConnection(patch, patchCacheItem, out var value))
                goto InvokeEvents;
            
            //In case propType or myClass is null, the path could be not implemented yet. 
            if (patchCacheItem.PropType is null || parentClass is null)
                throw new ArgumentOutOfRangeException($"Path not implemented: {patch.Path}");
            
            var genericType = GetGenericType(patchCacheItem.PropType, out var genType);
            switch (genericType)
            {
                case GenericTypeEnum.NonGeneric:
                    PatchNonGeneric(patch, patchCacheItem, out value);
                    break;
                
                case GenericTypeEnum.List:
                    PatchGenericList(patch, patchCacheItem, lastIndex, out value);
                    break;
                
                case GenericTypeEnum.Dictionary:
                    PatchGenericDictionary(patch, patchCacheItem, filePath, out value);
                    break;

                case GenericTypeEnum.Other:
                default:
                    throw new ArgumentOutOfRangeException($"{genType} is Generic but maybe isn't implemented");
            }
            
            InvokeEvents:
            if (ShouldInvokeEvents)
                InvokeEvent(patchCacheItem.SerialNumber, patchCacheItem.PathAsClasses, patchCacheItem.ParentClass, patchCacheItem.PropInfo, patch, value, lastIndex);
        }
        
        private void CreatePathSegments(string path, out string[] pathSegments,out int lastIndex, out string filePath)
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
                    patchCacheItem.ParentClass = type.GetProperty("Item")?.GetValue(patchCacheItem.ParentClass, new object[] { path }); //Get value of Device Dictionary with given SerialNumber
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

        private void PatchNonGeneric(Patch patch, PatchCacheItem patchCacheItem, out object value)
        {
            //If the Deserialization throws, there could be a problem with the Models
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

        private void PatchGenericList(Patch patch, PatchCacheItem patchCacheItem, int lastIndex, out object value)
        {
            //Since we know the Generic Type is a List, use it to cast to IList and manipulate it.
            var array = (IList)patchCacheItem.PropInfo.GetValue(patchCacheItem.ParentClass);
            value = default;
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

        private void PatchGenericDictionary(Patch patch, PatchCacheItem patchCacheItem, string filePath, out object value)
        {
            if (patchCacheItem.PropType.GetGenericArguments().FirstOrDefault() != typeof(string))
                throw new ArgumentOutOfRangeException($"{patchCacheItem.PropType.Name} is a Dictionary<T, S> but T, S maybe isn't implemented");
                
            //Since we know the Generic Type is a Dictionary, use it to cast to Dictionary and manipulate it.
            var dictionary = (IDictionary)patchCacheItem.PropInfo.GetValue(patchCacheItem.ParentClass);
                
            //Split the File Name from its path
            var splitPath = filePath.Split('/', '\\');
            value = splitPath[splitPath.Length - 1];
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
        
        private bool PatchDeviceConnection(Patch patch, PatchCacheItem patchCacheItem, out object value)
        {
            //Indicates that a GoXLR has been connected or removed
            value = default;
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
                    value = patch.Value.Deserialize<Device>(_serializerOptions);
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

        private void InvokeEvent(string serialNumber, IReadOnlyList<object> pathAsClasses, object parentClass, MemberInfo memInfo, Patch patch, object value, int lastIndex)
        {
            switch (parentClass)
            {
                case BankBaseButton bankBaseButton:
                    _events.Device.Sampler.SamplerBank.HandleEvents(serialNumber, (SamplerBankBase)pathAsClasses[pathAsClasses.Count - 2],
                        bankBaseButton, memInfo, patch.Op, lastIndex, null);
                   break;
                
                case ButtonDown buttonDown:
                    _events.Device.ButtonDown.HandleEvents(serialNumber, buttonDown, memInfo);
                    break;
                
                case Compressor compressor:
                    _events.Device.Mic.HandleCompressorEvents(serialNumber, compressor, memInfo);
                    break;
                
                case CoughButton coughButton:
                    _events.Device.CoughButton.HandleEvents(serialNumber, coughButton, memInfo);
                    break;
                
                case Config config:
                    _events.Config.HandleEvents(config, memInfo);
                    break;
                
                case Device device:
                    _events.HandleEvents(serialNumber, device);
                    break;
                
                case Dictionary<string, Device> _:
                    _events.HandleEvents(serialNumber, (Device)value);
                    break;
                    
                case EchoEffect _:
                case GenderEffect _:
                case HardTuneEffect _:
                case MegaphoneEffect _:
                case PitchEffect _:
                case ReverbEffect _:
                case RobotEffect _:
                    _events.Device.Effect.HandleCurrentEffectEvents(serialNumber, pathAsClasses[pathAsClasses.Count - 1], memInfo);
                    break;
                
                case Effects effects:
                    _events.Device.Effect.HandleEvents(serialNumber, effects, memInfo);
                    break;
                
                case FaderBase faderBase:
                    _events.Device.FaderStatus.HandleEvents(serialNumber, faderBase, memInfo, null);
                    break;
                
                case FaderScribble scribble:
                    _events.Device.FaderStatus.HandleEvents(serialNumber, (FaderBase)pathAsClasses[pathAsClasses.Count - 2], memInfo, scribble);
                    break;
                
                case Files files:
                    _events.File.HandleEvents(files, memInfo, patch.Op, value);
                    break;
                
                case Frequency frequency:
                    _events.Device.Mic.HandleEqualiserEvents(serialNumber, frequency, memInfo);
                    break;
                
                case FrequencyMini frequencyMini:
                    _events.Device.Mic.HandleEqualiserMiniEvents(serialNumber, frequencyMini, memInfo);
                    break;
                
                case Gain gain:
                    _events.Device.Mic.HandleEqualiserEvents(serialNumber, gain, memInfo);
                    break;
                
                case GainMini gainMini:
                    _events.Device.Mic.HandleEqualiserMiniEvents(serialNumber, gainMini, memInfo);
                    break;
                
                case GuiDisplay guiDisplay:
                    _events.Device.Settings.GuiDisplay.HandleEvents(serialNumber, guiDisplay, memInfo);
                    break;
                
                case Levels levels:
                    _events.Device.Levels.HandleEvents(serialNumber, levels, memInfo);
                    break;
                
                case MicGains micGains:
                    _events.Device.Mic.HandleMicGainEvents(serialNumber, micGains, memInfo);
                    break;
                
                case MicStatus micStatus:
                    _events.Device.Mic.HandleMicTypeEvents(serialNumber, micStatus);
                    break;
                
                case NoiseGate noiseGate:
                    _events.Device.Mic.HandleNoiseGateEvents(serialNumber, noiseGate, memInfo);
                    break;
                
                case Paths paths:
                    _events.Path.HandleEvents(paths, memInfo);
                    break;
                
                case PresetNames presetNames:
                    _events.Device.Effect.HandlePresetNamesEffectEvents(serialNumber, presetNames, memInfo);
                    break;
                
                case RouterBase routerBase:
                    _events.Device.Router.HandleEvents(serialNumber, routerBase, memInfo, (bool)value);
                    break;
                
                case Sample sample:
                    _events.Device.Sampler.SamplerBank.HandleEvents(serialNumber, (SamplerBankBase)pathAsClasses[pathAsClasses.Count - 4],
                        (BankBaseButton)pathAsClasses[pathAsClasses.Count - 3], memInfo, patch.Op, lastIndex, sample);
                    break;
                
                case Settings settings:
                    _events.Device.Settings.HandleEvents(serialNumber, settings, memInfo);
                    break;
                
                case Volume volumes:
                    _events.Device.Levels.Volume.HandleEvents(serialNumber, volumes, null, memInfo);
                    break;

                default:
                    var type = parentClass.GetType();
                    throw new ArgumentOutOfRangeException($"Type out of Range in PatchHandler: {type.Name} | Path: {type.FullName}");
            }
        }
    }
}