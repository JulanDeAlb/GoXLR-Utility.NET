using System.Collections.Generic;
using GoXLR_Utility.NET.Models.Patch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Files
{
    public class DictionaryFileEventArgs : System.EventArgs
    {
        public OpPatchEnum PatchType { get; set; }
        
        public Dictionary<string, string> Dictionary { get; set; }
        public object Item { get; set; }
    }
}