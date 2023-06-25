using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbLowColour : DeviceCommandBase
    {
        private const int MinValue = -50;
        private const int MaxValue = 50;

        /// <summary>
        /// Set the Reverb Low Colour of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-50 - 50)</param>
        public SetReverbLowColour(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetReverbLowColour), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetReverbLowColour), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbLowColour"] = value
            };
        }

        /// <summary>
        /// Set the Reverb Low Colour of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-50 - 50)</param>
        public SetReverbLowColour(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbLowColour), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbLowColour), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbLowColour"] = value
            };
        }
    }
}