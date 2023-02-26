using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Megaphone;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Megaphone
{
    public class SetMegaphoneStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Megaphone Style of the current Preset.
        /// </summary>
        /// <param name="style">The Style to apply</param>
        public SetMegaphoneStyle(MegaphoneStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetMegaphoneStyle"] = new object[]
                {
                    style.ToString()
                }
            };
        }
    }
}