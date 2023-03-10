using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace GoXLR_Utility.NET.Models
{
    public class PatchCache : ConcurrentDictionary<string, PatchCacheItem> { }
    
    public class PatchCacheItem
    {
        public object ParentClass { get; set; }

        public string[] PathSegments { get; set; }
        
        public PropertyInfo PropInfo { get; set; }
        
        public Type PropType { get; set; }
        
        public string SerialNumber { get; set; }

        public PatchCacheItem(object parentClass, string[] pathSegments)
        {
            ParentClass = parentClass;
            PathSegments = pathSegments;

            if (pathSegments[0].Equals("mixers", StringComparison.OrdinalIgnoreCase))
                SerialNumber = pathSegments[1];
        }
    }
}