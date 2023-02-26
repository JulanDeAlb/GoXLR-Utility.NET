using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.FaderStatus;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels.Volumes
{
    public class SetVolume : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 255;
        
        /// <summary>
        /// Set the Volume of a certain Channel
        /// </summary>
        /// <param name="channel">Channel to edit</param>
        /// <param name="volume">Volume as Byte</param>
        public SetVolume(ChannelName channel, byte volume)
        {
            Command = new Dictionary<string, object>
            {
                ["SetVolume"] = new object[]
                {
                    channel.ToString(),
                    volume
                }
            };
        }
        
        /// <summary>
        /// Set the Volume of a certain Channel
        /// </summary>
        /// <param name="channel">Channel to edit</param>
        /// <param name="volume">Volume as Int (0 - 255)</param>
        public SetVolume(ChannelName channel, int volume)
        {
            volume = volume < MinValue ? SetMinValue(nameof(SetVolume), MinValue) : volume;
            volume = volume > MaxValue ? SetMaxValue(nameof(SetVolume), MaxValue) : volume;
            
            Command = new Dictionary<string, object>
            {
                ["SetVolume"] = new object[]
                {
                    channel.ToString(),
                    volume
                }
            };
        }
    }
}