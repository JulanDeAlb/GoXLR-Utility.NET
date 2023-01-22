using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels
{
    public class SetDeeser : CommandBase
    {
        public SetDeeser(byte volume)
        {
            Command = new Dictionary<string, object>
            {
                ["SetDeeser"] = new
                {
                    volume
                }
            };
        }
    }
}