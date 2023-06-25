using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbDiffuse : DeviceCommandBase
    {
        private const int MinValue = -50;
        private const int MaxValue = 50;

        /// <summary>
        /// Set the Reverb Diffuse for the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-50 - 50)</param>
        public SetReverbDiffuse(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetReverbDiffuse), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetReverbDiffuse), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbDiffuse"] = value
            };
        }

        /// <summary>
        /// Set the Reverb Diffuse for the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-50 - 50)</param>
        public SetReverbDiffuse(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbDiffuse), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbDiffuse), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbDiffuse"] = value
            };
        }
    }
}