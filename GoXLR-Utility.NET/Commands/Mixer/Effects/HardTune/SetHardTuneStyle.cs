using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneStyle : CommandBase
    {
        public SetHardTuneStyle(HardTuneStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetHardTuneStyle"] = new
                {
                    style
                }
            };
        }
    }
}