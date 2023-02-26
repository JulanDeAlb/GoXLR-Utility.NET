using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus
{
    public class SetGateThreshold : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 72;

        /// <summary>
        /// Set the Microphone Gain
        /// </summary>
        /// <param name="type">The Type to edit</param>
        /// <param name="gain">Gain as Byte (0 - 72)</param>
        public SetGateThreshold(MicrophoneType type, byte gain)
        {
            gain = gain > MaxValue ? (byte) SetMaxValue(nameof(SetGateThreshold), MaxValue) : gain;

            Command = new Dictionary<string, object>
            {
                ["SetGateThreshold"] = new object[]
                {
                    type.ToString(),
                    gain
                }
            };
        }

        /// <summary>
        /// Set the Microphone Gain
        /// </summary>
        /// <param name="type">The Type to edit</param>
        /// <param name="gain">Gain as Int (0 - 72)</param>
        public SetGateThreshold(MicrophoneType type, int gain)
        {
            gain = gain < MinValue ? SetMinValue(nameof(SetGateThreshold), MinValue) : gain;
            gain = gain > MaxValue ? SetMaxValue(nameof(SetGateThreshold), MaxValue) : gain;

            Command = new Dictionary<string, object>
            {
                ["SetGateThreshold"] = new object[]
                {
                    type.ToString(),
                    gain
                }
            };
        }
    }
}