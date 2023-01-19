using System.Collections.Generic;
using GoXLR_Utility.NET.Models.Patch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Files
{
    public class DictionaryFileEventArgs : System.EventArgs
    {
        public Dictionary<string, string> Dictionary { get; internal set; }
        
        public object Item { get; internal set; }
        
        public OpPatchEnum PatchType { get; internal set; }
    }
}