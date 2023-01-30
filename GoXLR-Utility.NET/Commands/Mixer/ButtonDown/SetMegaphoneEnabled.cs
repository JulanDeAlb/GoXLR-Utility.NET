using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetMegaphoneEnabled : CommandBase
    {
        public SetMegaphoneEnabled(bool isEnabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetMegaphoneEnabled"] = new
                {
                    isEnabled
                }
            };
        }
    }
}