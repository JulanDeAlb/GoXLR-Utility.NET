using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels
{
    public class SetBleep : DeviceCommandBase
    {
        private const int MinValue = -36;
        private const int MaxValue = 0;

        /// <summary>
        /// Set the Bleep Volume
        /// </summary>
        /// <param name="volume">Volume as Byte (-36 - 0)</param>
        public SetBleep(sbyte volume)
        {
            volume = volume < MinValue ? (sbyte) SetMinValue(nameof(SetBleep), MinValue) : volume;
            volume = volume > MaxValue ? (sbyte) SetMaxValue(nameof(SetBleep), MaxValue) : volume;
            
            Command = new Dictionary<string, object>
            {
                ["SetSwearButtonVolume"] = volume
            };
        }
        
        /// <summary>
        /// Set the Bleep Volume
        /// </summary>
        /// <param name="volume">Volume as Int (-36 - 0)</param>
        public SetBleep(int volume)
        {
            volume = volume < MinValue ? SetMinValue(nameof(SetBleep), MinValue) : volume;
            volume = volume > MaxValue ? SetMaxValue(nameof(SetBleep), MaxValue) : volume;
            
            Command = new Dictionary<string, object>
            {
                ["SetSwearButtonVolume"] = volume
            };
        }
    }
}