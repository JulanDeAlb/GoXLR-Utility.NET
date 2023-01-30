using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.NoiseGate
{
    public class SetGateRelease : CommandBase
    {
        public SetGateRelease(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGateRelease"] = new
                {
                    value
                }
            };
        }
    }
}