using System;
using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Equaliser
{
    public class SetEqMiniGain : DeviceCommandBase
    {
        private const int MinValue = -9;
        private const int MaxValue = 9;

        /// <summary>
        /// Set the Gain of a certain Equaliser-Mini Frequency
        /// </summary>
        /// <param name="equaliser">The Frequency to edit</param>
        /// <param name="gain">Gain (-9 - 9)</param>
        public SetEqMiniGain(EqualiserMiniEnum equaliser, int gain)
        {
            gain = gain < MinValue ? SetMinValue(nameof(SetEqMiniGain), MinValue) : gain;
            gain = gain > MaxValue ? SetMaxValue(nameof(SetEqMiniGain), MaxValue) : gain;

            Command = new Dictionary<string, object>
            {
                ["SetEqMiniGain"] = new object[]
                {
                    equaliser.ToString(),
                    gain
                }
            };
        }

        /// <summary>
        /// Set the Gain of a certain Equaliser-Mini Frequency<br/>
        /// <br/>
        /// Base - 90HZ, 250HZ<br/>
        /// Mid - 500HZ, 1KHZ<br/>
        /// Treble - 3KHZ, 8KHZ<br/>
        /// </summary>
        /// <param name="equaliser">The Frequency to edit</param>
        /// <param name="gain">Gain (-9 - 9)</param>
        public SetEqMiniGain(SimpleEqualiserEnum equaliser, int gain)
        {
            switch (equaliser)
            {
                case SimpleEqualiserEnum.Bass:
                    gain = gain < MinValue ? SetMinValue(nameof(SetEqFrequency), MinValue) : gain;
                    gain = gain > MaxValue ? SetMaxValue(nameof(SetEqFrequency), MaxValue) : gain;

                    CommandList = new List<object>
                    {
                        new Dictionary<string, object>
                        {
                            ["SetEqMiniGain"] = new object[]
                            {
                                EqualiserMiniEnum.Equalizer90Hz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqMiniGain"] = new object[]
                            {
                                EqualiserMiniEnum.Equalizer250Hz.ToString(),
                                gain
                            }
                        }
                    };
                    break;

                case SimpleEqualiserEnum.Mid:
                    gain = gain < MinValue ? SetMinValue(nameof(SetEqFrequency), MinValue) : gain;
                    gain = gain > MaxValue ? SetMaxValue(nameof(SetEqFrequency), MaxValue) : gain;

                    CommandList = new List<object>
                    {
                        new Dictionary<string, object>
                        {
                            ["SetEqMiniGain"] = new object[]
                            {
                                EqualiserMiniEnum.Equalizer500Hz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqMiniGain"] = new object[]
                            {
                                EqualiserMiniEnum.Equalizer1KHz.ToString(),
                                gain
                            }
                        }
                    };
                    break;

                case SimpleEqualiserEnum.Treble:
                    gain = gain < MinValue ? SetMinValue(nameof(SetEqFrequency), MinValue) : gain;
                    gain = gain > MaxValue ? SetMaxValue(nameof(SetEqFrequency), MaxValue) : gain;

                    CommandList = new List<object>
                    {
                        new Dictionary<string, object>
                        {
                            ["SetEqMiniGain"] = new object[]
                            {
                                EqualiserMiniEnum.Equalizer3KHz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqMiniGain"] = new object[]
                            {
                                EqualiserMiniEnum.Equalizer8KHz.ToString(),
                                gain
                            }
                        }
                    };
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(equaliser), equaliser, null);
            }
        }
    }
}