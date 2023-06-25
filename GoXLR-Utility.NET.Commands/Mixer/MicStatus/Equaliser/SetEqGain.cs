using System;
using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;

namespace GoXLR_Utility.NET.Commands.Mixer.MicStatus.Equaliser
{
    public class SetEqGain : DeviceCommandBase
    {
        private const int MinValue = -9;
        private const int MaxValue = 9;

        /// <summary>
        /// Set the Gain of a certain Equaliser Frequency
        /// </summary>
        /// <param name="equaliser">The Frequency to edit</param>
        /// <param name="gain">Gain (-9 - 9)</param>
        public SetEqGain(EqualiserEnum equaliser, int gain)
        {
            gain = gain < MinValue ? SetMinValue(nameof(SetEqGain), MinValue) : gain;
            gain = gain > MaxValue ? SetMaxValue(nameof(SetEqGain), MaxValue) : gain;

            Command = new Dictionary<string, object>
            {
                ["SetEqGain"] = new object[]
                {
                    equaliser.ToString(),
                    gain
                }
            };
        }

        /// <summary>
        /// Set the Gain of a certain Equaliser Frequency<br/>
        /// <br/>
        /// Base - 31HZ, 63HZ, 125HZ, 250HZ<br/>
        /// Mid - 500HZ, 1KHZ, 2KHZ<br/>
        /// Treble - 4KHZ, 8KHZ, 16KHZ<br/>
        /// </summary>
        /// <param name="equaliser">The Frequency to edit</param>
        /// <param name="gain">Gain (-9 - 9)</param>
        public SetEqGain(SimpleEqualiserEnum equaliser, int gain)
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
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer31Hz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer63Hz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer125Hz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer250Hz.ToString(),
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
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer500Hz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer1KHz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer2KHz.ToString(),
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
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer4KHz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer8KHz.ToString(),
                                gain
                            }
                        },
                        new Dictionary<string, object>
                        {
                            ["SetEqGain"] = new object[]
                            {
                                EqualiserEnum.Equalizer16KHz.ToString(),
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