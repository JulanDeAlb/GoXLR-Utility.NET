using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Settings
{
    public class SetVcMuteAlsoMuteCm : DeviceCommandBase
    {
        /// <summary>
        /// Set the VoiceChat Mute should also mute ChatMic.
        /// </summary>
        /// <param name="mute">True to also Mute</param>
        public SetVcMuteAlsoMuteCm(bool mute)
        {
            Command = new Dictionary<string, object>
            {
                ["SetVCMuteAlsoMuteCM"] = mute
            };
        }
    }
}