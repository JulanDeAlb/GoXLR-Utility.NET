using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Reverb
{
    public class SetReverbDecay : DeviceCommandBase
    {
        private const int MinValue = 10;
        private const int MaxValue = 20000;

        /// <summary>
        /// Set the Reverb Decay of the current Preset.<br/>
        /// <br/>
        /// Steps:<br/>
        /// 10 - 990 = 20<br/>
        /// 1000 - 20000 = 100
        /// </summary>
        /// <param name="value">Value as Int (10 - 20000)</param>
        public SetReverbDecay(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetReverbDecay), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetReverbDecay), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetReverbDecay"] = value
            };
        }
    }
}