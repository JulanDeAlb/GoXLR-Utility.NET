using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Pitch;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Pitch
{
    public class SetPitchStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Pitch Style of the current Preset.
        /// </summary>
        /// <param name="style">The Style to apply.</param>
        public SetPitchStyle(PitchStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetPitchStyle"] = style.ToString()
            };
        }
    }
}