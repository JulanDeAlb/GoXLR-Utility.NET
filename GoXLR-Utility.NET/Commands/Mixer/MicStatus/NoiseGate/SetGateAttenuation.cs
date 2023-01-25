using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.NoiseGate
{
    public class SetGateAttenuation : CommandBase
    {
        public SetGateAttenuation(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGateAttenuation"] = new
                {
                    value
                }
            };
        }
    }
}