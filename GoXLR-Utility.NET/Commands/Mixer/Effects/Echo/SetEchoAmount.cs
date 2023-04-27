using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoAmount : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Echo Amount of the Current Preset.
        /// </summary>
        /// <param name="value">The Amount as Byte (0 - 100)</param>
        public SetEchoAmount(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetEchoAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoAmount"] = value
            };
        }

        /// <summary>
        /// Set the Echo Amount of the Current Preset.
        /// </summary>
        /// <param name="value">The Amount as Int (0 - 100)</param>
        public SetEchoAmount(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetEchoAmount), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetEchoAmount), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoAmount"] = value
            };
        }
    }
}