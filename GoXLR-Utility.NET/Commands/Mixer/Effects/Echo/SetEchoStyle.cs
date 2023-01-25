using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Echo;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoStyle : CommandBase
    {
        public SetEchoStyle(EchoStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetEchoStyle"] = new
                {
                    style
                }
            };
        }
    }
}