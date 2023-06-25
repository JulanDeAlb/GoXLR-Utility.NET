using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbHighFactor : DeviceCommandBase
    {
        private const int MinValue = -25;
        private const int MaxValue = 25;

        /// <summary>
        /// Set the Reverb High Factor of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-25 - 25)</param>
        public SetReverbHighFactor(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetReverbHighFactor), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetReverbHighFactor), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbHighFactor"] = value
            };
        }

        /// <summary>
        /// Set the Reverb High Factor of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-25 - 25)</param>
        public SetReverbHighFactor(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbHighFactor), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbHighFactor), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbHighFactor"] = value
            };
        }
    }
}