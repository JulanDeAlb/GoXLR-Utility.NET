using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbHighColour : DeviceCommandBase
    {
        private const int MinValue = -50;
        private const int MaxValue = 50;

        /// <summary>
        /// Set the Reverb High Colour of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-50 - 50)</param>
        public SetReverbHighColour(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetReverbHighColour), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetReverbHighColour), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbHighColour"] = value
            };
        }

        /// <summary>
        /// Set the Reverb High Colour of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-50 - 50)</param>
        public SetReverbHighColour(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbHighColour), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbHighColour), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbHighColour"] = value
            };
        }
    }
}