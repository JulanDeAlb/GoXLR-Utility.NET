using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Pitch
{
    public class SetPitchCharacter : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Pitch Character of the current Preset.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetPitchCharacter(byte value)
        {
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetPitchCharacter), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetPitchCharacter"] = new
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Pitch Character of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetPitchCharacter(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetPitchCharacter), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetPitchCharacter), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetPitchCharacter"] = new
                {
                    value
                }
            };
        }
    }
}