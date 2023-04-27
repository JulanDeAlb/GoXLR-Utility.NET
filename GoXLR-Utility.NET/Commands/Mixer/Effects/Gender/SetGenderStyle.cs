using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Gender;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Gender
{
    public class SetGenderStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Gender Style of the current Preset.
        /// </summary>
        /// <param name="style">The style to apply</param>
        public SetGenderStyle(GenderStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGenderStyle"] = style.ToString()
            };
        }
    }
}