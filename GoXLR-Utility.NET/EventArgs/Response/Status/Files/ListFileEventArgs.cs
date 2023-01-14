using System.Collections.Generic;
using GoXLR_Utility.NET.Models.Patch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Files
{
    public class ListFileEventArgs : System.EventArgs
    {
        public OpPatchEnum PatchType { get; set; }
        public List<string> List { get; set; }
        public string Item { get; set; }
    }
}