using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbModDepth: DeviceCommandBase
    {
        private const int MinValue = -25;
        private const int MaxValue = 25;

        /// <summary>
        /// Set the Reverb Mod Depth of the current Preset.
        /// </summary>
        /// <param name="value">Value as sByte (-25 - 25</param>
        public SetReverbModDepth(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetReverbModDepth), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetReverbModDepth), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbModDepth"] = value
            };
        }

        /// <summary>
        /// Set the Reverb Mod Depth of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (-25 - 25</param>
        public SetReverbModDepth(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbModDepth), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbModDepth), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbModDepth"] = value
            };
        }
    }
}