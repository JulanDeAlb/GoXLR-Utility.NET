using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Encoder;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Encoder
{
    public class SetEncoderColour : CommandBase
    {
        public SetEncoderColour(EncoderEnum encoder, string colour1, string colour2, string colour3)
        {
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