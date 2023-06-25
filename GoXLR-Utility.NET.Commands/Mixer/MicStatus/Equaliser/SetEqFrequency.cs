using System;
using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Equaliser
{
    public class SetEqFrequency : DeviceCommandBase
    {
        private static readonly int[] MinValues = { 30, 300, 2000};
        private static readonly int[] MaxValues = { 250, 2000, 18000};

        /// <summary>
        /// Set the specific Frequency of a certain Equaliser Frequency<br/>
        /// <br/>
        /// Valid input for certain Frequency's:<br/>
        /// <br/>
        /// 31HZ: 30 - 250<br/>
        /// 63HZ: 30 - 250<br/>
        /// 125HZ: 30 - 250<br/>
        /// 250HZ: 30 - 250<br/>
        /// <br/>
        /// 500HZ: 300 - 2000<br/>
        /// 1KHZ: 300 - 2000<br/>
        /// 2KHZ: 300 - 2000<br/>
        /// <br/>
        /// 4KHZ: 2000 - 18000<br/>
        /// 8KHZ: 2000 - 18000<br/>
        /// 16KHZ: 2000 - 18000<br/>
        /// </summary>
        /// <param name="equaliser">The Frequency to edit</param>
        /// <param name="gain">Frequency</param>
        public SetEqFrequency(EqualiserEnum equaliser, int gain)
        {
            switch (equaliser)
            {
                case EqualiserEnum.Equalizer31Hz:
                case EqualiserEnum.Equalizer63Hz:
                case EqualiserEnum.Equalizer125Hz:
                case EqualiserEnum.Equalizer250Hz:
                    gain = gain < MinValues[0] ? SetMinValue(nameof(SetEqFrequency), MinValues[0]) : gain;
                    gain = gain > MaxValues[0] ? SetMaxValue(nameof(SetEqFrequency), MaxValues[0]) : gain;
                    break;

                case EqualiserEnum.Equalizer500Hz:
                case EqualiserEnum.Equalizer1KHz:
                case EqualiserEnum.Equalizer2KHz:
                    gain = gain < MinValues[1] ? SetMinValue(nameof(SetEqFrequency), MinValues[1]) : gain;
                    gain = gain > MaxValues[1] ? SetMaxValue(nameof(SetEqFrequency), MaxValues[1]) : gain;
                    break;

                case EqualiserEnum.Equalizer4KHz:
                case EqualiserEnum.Equalizer8KHz:
                case EqualiserEnum.Equalizer16KHz:
                    gain = gain < MinValues[2] ? SetMinValue(nameof(SetEqFrequency), MinValues[2]) : gain;
                    gain = gain > MaxValues[2] ? SetMaxValue(nameof(SetEqFrequency), MaxValues[2]) : gain;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(equaliser), equaliser, null);
            }

            Command = new Dictionary<string, object>
            {
                ["SetEqFreq"] = new object[]
                {
                    equaliser.ToString(),
                    gain
                }
            };
        }
    }
}