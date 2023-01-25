using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Reverb;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbStyle : CommandBase
    {
        public SetReverbStyle(ReverbStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetReverbStyle"] = new
                {
                    style
                }
            };
        }
    }
}