using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.HardTune;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneSource : CommandBase
    {
        public SetHardTuneSource(HardTuneSource source)
        {
            Command = new Dictionary<string, object>
            {
                ["SetHardTuneSource"] = new
                {
                    source
                }
            };
        }
    }
}