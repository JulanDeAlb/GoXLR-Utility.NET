using System;
using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Equaliser
{
    public class SetEqMiniFrequency : DeviceCommandBase
    {
        private static readonly int[] MinValues = { 30, 100, 310, 800, 2600, 5100};
        private static readonly int[] MaxValues = { 90, 300, 800, 2500, 5000, 18000};

        /// <summary>
        /// Set the specific Frequency of a certain Equaliser-Mini Frequency<br/>
        /// <br/>
        /// Valid input for certain Frequency's:<br/>
        /// <br/>
        /// 90HZ: 30 - 300<br/>
        /// 250HZ: 30 - 300<br/>
        /// <br/>
        /// 500HZ: 300 - 2000<br/>
        /// 1KHZ: 300 - 2000<br/>
        /// <br/>
        /// 3KHZ: 2100 - 18000<br/>
        /// 8KHZ: 2100 - 18000<br/>
        /// </summary>
        /// <param name="equaliser">The Frequency to edit</param>
        /// <param name="gain">Frequency</param>
        public SetEqMiniFrequency(EqualiserMiniEnum equaliser, int gain)
        {
            switch (equaliser)
            {
                case EqualiserMiniEnum.Equalizer90Hz:
                    gain = gain < MinValues[0] ? SetMinValue(nameof(SetEqMiniFrequency), MinValues[0]) : gain;
                    gain = gain > MaxValues[0] ? SetMaxValue(nameof(SetEqMiniFrequency), MaxValues[0]) : gain;
                    break;

                case EqualiserMiniEnum.Equalizer250Hz:
                    gain = gain < MinValues[1] ? SetMinValue(nameof(SetEqMiniFrequency), MinValues[1]) : gain;
                    gain = gain > MaxValues[1] ? SetMaxValue(nameof(SetEqMiniFrequency), MaxValues[1]) : gain;
                    break;

                case EqualiserMiniEnum.Equalizer500Hz:
                    gain = gain < MinValues[2] ? SetMinValue(nameof(SetEqMiniFrequency), MinValues[2]) : gain;
                    gain = gain > MaxValues[2] ? SetMaxValue(nameof(SetEqMiniFrequency), MaxValues[2]) : gain;
                    break;

                case EqualiserMiniEnum.Equalizer1KHz:
                    gain = gain < MinValues[3] ? SetMinValue(nameof(SetEqMiniFrequency), MinValues[3]) : gain;
                    gain = gain > MaxValues[3] ? SetMaxValue(nameof(SetEqMiniFrequency), MaxValues[3]) : gain;
                    break;

                case EqualiserMiniEnum.Equalizer3KHz:
                    gain = gain < MinValues[4] ? SetMinValue(nameof(SetEqMiniFrequency), MinValues[4]) : gain;
                    gain = gain > MaxValues[4] ? SetMaxValue(nameof(SetEqMiniFrequency), MaxValues[4]) : gain;
                    break;

                case EqualiserMiniEnum.Equalizer8KHz:
                    gain = gain < MinValues[5] ? SetMinValue(nameof(SetEqMiniFrequency), MinValues[5]) : gain;
                    gain = gain > MaxValues[5] ? SetMaxValue(nameof(SetEqMiniFrequency), MaxValues[5]) : gain;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(equaliser), equaliser, null);
            }

            Command = new Dictionary<string, object>
            {
                ["SetEqMiniFreq"] = new object[]
                {
                    equaliser.ToString(),
                    gain
                }
            };
        }
    }
}