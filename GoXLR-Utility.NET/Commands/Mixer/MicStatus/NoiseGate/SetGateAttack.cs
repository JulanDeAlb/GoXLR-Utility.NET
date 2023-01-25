using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.NoiseGate
{
    public class SetGateAttack : CommandBase
    {
        public SetGateAttack(int value)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGateAttack"] = new
                {
                    value
                }
            };
        }
    }
}