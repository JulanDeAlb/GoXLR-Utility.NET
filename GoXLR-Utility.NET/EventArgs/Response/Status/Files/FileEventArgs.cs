using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Files;
using GoXLR_Utility.NET.Models.Patch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Files
{
    public class FileEventArgs : System.EventArgs
    {
        public OpPatchEnum PatchType { get; set; }
        
        /// <summary>
        /// Indicating which type of the File has been changed
        /// </summary>
        public FileEnum FileEnum { get; set; }
        
        public Dictionary<string, string> Dictionary { get; set; }
        
        public List<string> List { get; set; }
        
        public object Item { get; set; }
    }
}