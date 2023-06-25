using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Commands;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.NoiseGate
{
    public class SetGateAttack : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 44;

        /// <summary>
        /// Set the Gate Attack timing.
        /// </summary>
        /// <param name="timing">The timing to apply</param>
        public SetGateAttack(GateTiming timing)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGateAttack"] = timing
            };
        }

        /// <summary>
        /// Set the Gate Attack timing.
        /// </summary>
        /// <param name="timing">The timing as Byte (0 - 44)</param>
        public SetGateAttack(byte timing)
        {
            timing = timing > MaxValue ? (byte) SetMaxValue(nameof(SetGateAttack), MaxValue) : timing;

            Command = new Dictionary<string, object>
            {
                ["SetGateAttack"] = timing
            };
        }

        /// <summary>
        /// Set the Gate Attack timing.
        /// </summary>
        /// <param name="timing">The timing as Int (0 - 44)</param>
        public SetGateAttack(int timing)
        {
            timing = timing < MinValue ? SetMinValue(nameof(SetGateAttack), MinValue) : timing;
            timing = timing > MaxValue ? SetMaxValue(nameof(SetGateAttack), MaxValue) : timing;

            Command = new Dictionary<string, object>
            {
                ["SetGateAttack"] = timing
            };
        }
    }
}