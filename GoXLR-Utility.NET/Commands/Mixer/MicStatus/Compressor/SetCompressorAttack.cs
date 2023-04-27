using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Commands;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Compressor
{
    public class SetCompressorAttack : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 19;

        /// <summary>
        /// Set the Compressor Attack timing.
        /// </summary>
        /// <param name="timing">The timing to apply</param>
        public SetCompressorAttack(CompAttackTime timing)
        {
            Command = new Dictionary<string, object>
            {
                ["SetCompressorAttack"] = timing
            };
        }

        /// <summary>
        /// Set the Compressor Attack timing.
        /// </summary>
        /// <param name="timing">The timing to apply as Byte (0 - 19)</param>
        public SetCompressorAttack(byte timing)
        {
            timing = timing > MaxValue ? (byte) SetMaxValue(nameof(SetCompressorAttack), MaxValue) : timing;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorAttack"] = timing
            };
        }

        /// <summary>
        /// Set the Compressor Attack timing.
        /// </summary>
        /// <param name="timing">The timing to apply as Int (0 - 19)</param>
        public SetCompressorAttack(int timing)
        {
            timing = timing < MinValue ? SetMinValue(nameof(SetCompressorAttack), MinValue) : timing;
            timing = timing > MaxValue ? SetMaxValue(nameof(SetCompressorAttack), MaxValue) : timing;

            Command = new Dictionary<string, object>
            {
                ["SetCompressorAttack"] = timing
            };
        }
    }
}