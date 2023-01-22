using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels
{
    public class SetBleep : CommandBase
    {
        public SetBleep(byte volume)
        {
            Command = new Dictionary<string, object>
            {
                ["SetBleep"] = new
                {
                    volume
                }
            };
        }
    }
}