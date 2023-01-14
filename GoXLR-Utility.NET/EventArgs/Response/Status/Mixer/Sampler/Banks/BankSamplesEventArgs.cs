using System.Collections.Generic;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks.Sample;

namespace GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks
{
    public class BankSamplesEventArgs : System.EventArgs
    {
       public List<Sample> Samples { get; set; }
        
        public string SerialNumber { get; set; }
    }
}