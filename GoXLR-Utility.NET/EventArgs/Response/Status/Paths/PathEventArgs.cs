using GoXLR_Utility.NET.Enums.Response.Status.Paths;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Paths
{
    public class PathEventArgs : System.EventArgs
    {
        /// <summary>
        /// Indicating which type of the Path has been changed
        /// </summary>
        public PathEnum TypeChanged { get; internal set; }

        public string Value { get; internal set; }
    }
}