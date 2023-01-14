namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.CoughButton
{
    public class CoughIsToggledEventArgs : System.EventArgs
    {
        public bool IsToggle { get; set; }
        public string SerialNumber { get; set; }
    }
}