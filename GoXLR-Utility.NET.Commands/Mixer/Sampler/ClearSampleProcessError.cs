using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class ClearSampleProcessError : DeviceCommandBase
    {
        /// <summary>
        /// Clear the sample process error.
        /// </summary>
        public ClearSampleProcessError()
        {
            Command = new Dictionary<string, object>
            {
                ["ClearSampleProcessError"] = new object[] { }
            };
        }
    }
}