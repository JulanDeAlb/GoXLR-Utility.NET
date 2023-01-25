using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Encoder;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Encoder
{
    public class SetEncoderColour : CommandBase
    {
        public SetEncoderColour(EncoderEnum encoder, string colour1, string colour2, string colour3)
        {
            colour1 = colour1.Replace("#", "");
            colour2 = colour2.Replace("#", "");
            colour3 = colour3.Replace("#", "");
            Command = new Dictionary<string, object>
            {
                ["SetEncoderColour"] = new
                {
                    encoder,
                    colour1,
                    colour2,
                    colour3
                }
            };
        }
    }
}