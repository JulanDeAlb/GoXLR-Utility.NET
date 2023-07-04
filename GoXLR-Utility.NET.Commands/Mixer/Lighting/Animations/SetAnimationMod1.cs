using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Animations
{
    public class SetAnimationMod1 : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        /// <summary>
        /// Set the Animation modifier 1.
        /// </summary>
        /// <param name="value">Value as Byte (0 - 100)</param>
        public SetAnimationMod1(byte value)
        {
            value = value < MinValue ? (byte) SetMinValue(nameof(SetAnimationMod1), MinValue) : value;
            value = value > MaxValue ? (byte) SetMaxValue(nameof(SetAnimationMod1), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetAnimationMod1"] = value
            };
        }

        /// <summary>
        /// Set the Animation modifier 1.
        /// </summary>
        /// <param name="value">Value as Int (0 - 100)</param>
        public SetAnimationMod1(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetAnimationMod1), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetAnimationMod1), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetAnimationMod1"] = value
            };
        }
    }
}