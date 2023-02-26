using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoStyle : DeviceCommandBase
    {
        /// <summary>
        /// Set the Echo Style of the current Preset.
        /// </summary>
        /// <param name="style">The style to apply</param>
        public SetEchoStyle(EchoStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEchoStyle"] = new object[]
                {
                    style.ToString()
                }
            };
        }
    }
}