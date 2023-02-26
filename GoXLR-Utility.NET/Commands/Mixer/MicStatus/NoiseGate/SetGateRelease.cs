using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Commands;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.NoiseGate
{
    public class SetGateRelease : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 44;

        /// <summary>
        /// Set the Gate Release timing.
        /// </summary>
        /// <param name="timing">The timing to apply</param>
        public SetGateRelease(GateTiming timing)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGateRelease"] = new object[]
                {
                    timing
                }
            };
        }

        /// <summary>
        /// Set the Gate Attack timing.
        /// </summary>
        /// <param name="timing">The timing as Byte (0 - 44)</param>
        public SetGateRelease(byte timing)
        {
            timing = timing > MaxValue ? (byte) SetMaxValue(nameof(SetGateAttack), MaxValue) : timing;

            Command = new Dictionary<string, object>
            {
                ["SetGateRelease"] = new object[]
                {
                    timing
                }
            };
        }

        /// <summary>
        /// Set the Gate Attack timing.
        /// </summary>
        /// <param name="timing">The timing as Int (0-44)</param>
        public SetGateRelease(int timing)
        {
            timing = timing < MinValue ? SetMinValue(nameof(SetGateAttack), MinValue) : timing;
            timing = timing > MaxValue ? SetMaxValue(nameof(SetGateAttack), MaxValue) : timing;

            Command = new Dictionary<string, object>
            {
                ["SetGateRelease"] = new object[]
                {
                    timing
                }
            };
        }
    }
}