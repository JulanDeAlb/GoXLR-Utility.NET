using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Animations
{
    public class SetAnimationMod2 : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Animation modifier 1.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetAnimationMod2(byte value)
        {
            value = value < MinValue ? (byte) SetMinValue(nameof(SetAnimationMod2), MinValue) : value;
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetAnimationMod2), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetAnimationMod2"] = value
            };
        }

        /// <summary>
        /// Set the Animation modifier 1.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetAnimationMod2(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetAnimationMod2), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetAnimationMod2), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetAnimationMod2"] = value
            };
        }
    }
}