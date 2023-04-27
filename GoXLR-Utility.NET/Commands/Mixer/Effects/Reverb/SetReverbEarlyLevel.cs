using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbEarlyLevel : DeviceCommandBase
    {
        private const int MinValue = -25;
        private const int MaxValue = 0;

        /// <summary>
        /// Set the Reverb Early Level of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-25 - 0)</param>
        public SetReverbEarlyLevel(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetReverbEarlyLevel), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetReverbEarlyLevel), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbEarlyLevel"] = value
            };
        }

        /// <summary>
        /// Set the Reverb Early Level of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-25 - 0)</param>
        public SetReverbEarlyLevel(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbEarlyLevel), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbEarlyLevel), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbEarlyLevel"] = value
            };
        }
    }
}