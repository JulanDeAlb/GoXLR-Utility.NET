using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Megaphone
{
    public class SetMegaphonePostGain : DeviceCommandBase
    {
        private const int MinValue = -20;
        private const int MaxValue = 20;

        /// <summary>
        /// Set the Megaphone Post Gain of the current Preset
        /// </summary>
        /// <param name="value">Value as sByte (-20 - 20)</param>
        public SetMegaphonePostGain(sbyte value)
        {
            value = value < MinValue ? (sbyte) SetMinValue(nameof(SetMegaphonePostGain), MinValue) : value;
            value = value > MaxValue ? (sbyte) SetMaxValue(nameof(SetMegaphonePostGain), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetMegaphonePostGain"] = value
            };
        }

        /// <summary>
        /// Set the Megaphone Post Gain of the current Preset
        /// </summary>
        /// <param name="value">Value as Int (-20 - 20)</param>
        public SetMegaphonePostGain(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetMegaphonePostGain), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetMegaphonePostGain), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetMegaphonePostGain"] = value
            };
        }
    }
}