using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.HardTune
{
    public class SetHardTuneWindow : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 600;

        /// <summary>
        /// Set the HardTune Window of the current Style.
        /// </summary>
        /// <param name="value">Value as Int (0 - 600)</param>
        public SetHardTuneWindow(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetHardTuneWindow), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetHardTuneWindow), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetHardTuneWindow"] = value
            };
        }
    }
}