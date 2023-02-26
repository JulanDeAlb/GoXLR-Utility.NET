using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbTailLevel : DeviceCommandBase
    {
        private const int MinValue = -25;
        private const int MaxValue = 0;

        /// <summary>
        /// Set the Reverb Tail Level of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-25 - 0)</param>
        public SetReverbTailLevel(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetReverbTailLevel), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetReverbTailLevel), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbTailLevel"] = new
                {
                    value
                }
            };
        }

        /// <summary>
        /// Set the Reverb Tail Level of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-25 - 0)</param>
        public SetReverbTailLevel(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbTailLevel), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbTailLevel), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbTailLevel"] = new
                {
                    value
                }
            };
        }
    }
}