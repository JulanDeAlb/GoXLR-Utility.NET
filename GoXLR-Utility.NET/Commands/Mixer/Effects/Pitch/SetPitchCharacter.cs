using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Pitch
{
    public class SetPitchCharacter : CommandBase
    {
        public SetPitchCharacter(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetPitchCharacter"] = new
                {
                    value
                }
            };
        }
    }
}