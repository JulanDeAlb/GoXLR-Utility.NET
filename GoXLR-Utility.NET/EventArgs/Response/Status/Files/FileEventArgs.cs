using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Files;
using GoXLR_Utility.NET.Models.Patch;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Files
{
    public class FileEventArgs : System.EventArgs
    {
        public Dictionary<string, string> Dictionary { get; internal set; }
        
        public object Item { get; internal set; }
        
        public List<string> List { get; internal set; }
        
        public OpPatchEnum PatchType { get; internal set; }
        
        /// <summary>
        /// Indicating which type of the File has been changed
        /// </summary>
        public FileEnum TypeChanged { get; internal set; }
    }
}