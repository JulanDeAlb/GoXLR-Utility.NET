using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.NoiseGate
{
    public class SetGateAttenuation : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Gate Attenuation.
        /// </summary>
        /// <param name="value">The value as Byte (0 - 100)</param>
        public SetGateAttenuation(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetGateAttenuation), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetGateAttenuation"] = value
            };
        }

        /// <summary>
        /// Set the Gate Attenuation.
        /// </summary>
        /// <param name="value">The value as Int (0 - 100)</param>
        public SetGateAttenuation(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetGateAttenuation), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetGateAttenuation), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetGateAttenuation"] = value
            };
        }
    }
}