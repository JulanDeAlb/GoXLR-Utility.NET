using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects
{
    public class SaveActivePreset : DeviceCommandBase
    {
        /// <summary>
        /// Save the active Effect Preset.
        /// </summary>
        public SaveActivePreset()
        {
            Command = new Dictionary<string, object>
            {
                ["SaveActivePreset"] = new object[] { }
            };
        }
    }
}