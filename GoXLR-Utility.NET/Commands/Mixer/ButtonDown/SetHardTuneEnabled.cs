using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetHardTuneEnabled : CommandBase
    {
        public SetHardTuneEnabled(bool isEnabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetHardTuneEnabled"] = new
                {
                    isEnabled
                }
            };
        }
    }
}