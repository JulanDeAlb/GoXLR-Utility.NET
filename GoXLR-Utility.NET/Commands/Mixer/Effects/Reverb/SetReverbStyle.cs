using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Reverb;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Reverb Style of the current Preset.
        /// </summary>
        /// <param name="style">The Style to apply</param>
        public SetReverbStyle(ReverbStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbStyle"] = style.ToString()
            };
        }
    }
}