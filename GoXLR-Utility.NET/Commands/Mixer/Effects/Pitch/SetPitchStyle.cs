using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Pitch;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Pitch
{
    public class SetPitchStyle : CommandBase
    {
        public SetPitchStyle(PitchStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetPitchStyle"] = new
                {
                    style
                }
            };
        }
    }
}