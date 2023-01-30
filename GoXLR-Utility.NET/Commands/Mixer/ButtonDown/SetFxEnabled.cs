using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetFxEnabled : CommandBase
    {
        public SetFxEnabled(bool isEnabled)
        {
            Command = new Dictionary<string, object>
            {
                ["SetFXEnabled"] = new
                {
                    isEnabled
                }
            };
        }
    }
}