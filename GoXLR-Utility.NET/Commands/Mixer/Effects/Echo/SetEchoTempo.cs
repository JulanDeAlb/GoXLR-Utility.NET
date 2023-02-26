using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Echo
{
    public class SetEchoTempo : DeviceCommandBase
    {
        private const int MinValue = 45;
        private const int MaxValue = 300;

        /// <summary>
        /// Set the Echo Tempo of the current Preset.
        /// </summary>
        /// <param name="value">Value as Int (45 - 300)</param>
        public SetEchoTempo(int value)
        {
            value = value < MinValue ? SetMinValue(nameof(SetEchoTempo), MinValue) : value;
            value = value > MaxValue ? SetMaxValue(nameof(SetEchoTempo), MaxValue) : value;

            Command = new Dictionary<string, object>
            {
                ["SetEchoTempo"] = new object[]
                {
                    value
                }
            };
        }
    }
}