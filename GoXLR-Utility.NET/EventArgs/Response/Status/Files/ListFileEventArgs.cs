using System.Collections.Generic;
using GoXLR_Utility.NET.Models.Patch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Files
{
    public class ListFileEventArgs : System.EventArgs
    {
        public string Item { get; internal set; }
        
        public List<string> List { get; internal set; }
        
        public OpPatchEnum PatchType { get; internal set; }
    }
}