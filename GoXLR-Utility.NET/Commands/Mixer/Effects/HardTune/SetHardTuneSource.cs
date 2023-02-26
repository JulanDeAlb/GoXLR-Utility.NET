using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneSource : DeviceCommandBase
    {
        /// <summary>
        /// Set the HardTune Source of the current Preset.
        /// </summary>
        /// <param name="source">The Source to apply</param>
        public SetHardTuneSource(HardTuneSource source)
        {
            Command = new Dictionary<string, object>
            {
                ["SetHardTuneSource"] = new object[]
                {
                    source.ToString()
                }
            };
        }
    }
}