using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Router;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels.Submix
{
    public class SetSubMixVolume : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 255;
        
        /// <summary>
        /// Set the Volume of a certain Submix Channel
        /// </summary>
        /// <param name="channel">The channel to edit</param>
        /// <param name="volume">Volume as Byte</param>
        public SetSubMixVolume(InputDevice channel, byte volume)
        {
            Command = new Dictionary<string, object>
            {
                ["SetSubMixVolume"] = new object[]
                {
                    channel.ToString(),
                    volume
                }
            };
        }
        
        
        /// <summary>
        /// Set the Volume of a certain Submix Channel
        /// </summary>
        /// <param name="channel">The channel to edit</param>
        /// <param name="volume">Volume as Int</param>
        public SetSubMixVolume(InputDevice channel, int volume)
        {
            volume = volume < MinValue ? SetMinValue(nameof(SetSubMixVolume), MinValue) : volume;
            volume = volume > MaxValue ? SetMaxValue(nameof(SetSubMixVolume), MaxValue) : volume;
            
            Command = new Dictionary<string, object>
            {
                ["SetSubMixVolume"] = new object[]
                {
                    channel.ToString(),
                    volume
                }
            };
        }
    }
}