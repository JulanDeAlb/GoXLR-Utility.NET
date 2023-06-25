using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbModSpeed : DeviceCommandBase
    {
        private const int MinValue = -25;
        private const int MaxValue = 25;

        /// <summary>
        /// Set Reverb Mod Speed of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-25 - 25)</param>
        public SetReverbModSpeed(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetReverbModSpeed), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetReverbModSpeed), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbModSpeed"] = value
            };
        }

        /// <summary>
        /// Set Reverb Mod Speed of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-25 - 25)</param>
        public SetReverbModSpeed(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbModSpeed), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbModSpeed), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbModSpeed"] = value
            };
        }
    }
}