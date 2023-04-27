using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Levels
{
    public class SetDeeser : DeviceCommandBase
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;
        
        /// <summary>
        /// Set the De-Esser Volume
        /// </summary>
        /// <param name="volume">Volume as Byte (0 - 100)</param>
        public SetDeeser(byte volume)
        {
            volume = volume > MaxValue ? (byte) SetMinValue(nameof(SetDeeser), MinValue) : volume;
            
            Command = new Dictionary<string, object>
            {
                ["SetDeeser"] = volume
            };
        }
        
        /// <summary>
        /// Set the De-Esser Volume
        /// </summary>
        /// <param name="volume">Volume as Int (0 - 100)</param>
        public SetDeeser(int volume)
        {
            volume = volume < MinValue ? SetMinValue(nameof(SetDeeser), MinValue) : volume;
            volume = volume > MaxValue ? SetMaxValue(nameof(SetDeeser), MaxValue) : volume;
            
            Command = new Dictionary<string, object>
            {
                ["SetDeeser"] = volume
            };
        }
    }
}