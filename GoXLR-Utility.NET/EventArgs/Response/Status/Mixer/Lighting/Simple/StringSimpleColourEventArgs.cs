namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Simple
{
    public class StringSimpleColourEventArgs : System.EventArgs
    {
        public string SerialNumber { get; internal set; }
        
        public string Value { get; internal set; }
    }
}