using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.CoughButton
{
    public class SetCoughIsHold : CommandBase
    {
        public SetCoughIsHold(bool isHold)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCoughIsHold"] = new
                {
                    isHold
                }
            };
        }
    }
}