using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.NoiseGate
{
    public class SetGateActive : DeviceCommandBase
    {
        /// <summary>
        /// Set the Gate to be active or not.
        /// </summary>
        /// <param name="active">The bool</param>
        public SetGateActive(bool active)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGateActive"] = new object[]
                {
                    active
                }
            };
        }
    }
}