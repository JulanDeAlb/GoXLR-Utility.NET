using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the HardTune Style of the current Preset.
        /// </summary>
        /// <param name="style">The Style to apply</param>
        public SetHardTuneStyle(HardTuneStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetHardTuneStyle"] = new object[]
                {
                    style.ToString()
                }
            };
        }
    }
}