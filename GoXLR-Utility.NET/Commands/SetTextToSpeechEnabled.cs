using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands
{
    public class SetTextToSpeechEnabled : CommandBase
    {
        /// <summary>
        /// Enable or disable the Text to Speech.
        /// </summary>
        /// <param name="enable">True to enable</param>
        public SetTextToSpeechEnabled(bool enable)
        {
            Command = new Dictionary<string, object>
            {
                ["SetTTSEnabled"] = new object[]
                {
                    enable
                }
            };
        }
    }
}