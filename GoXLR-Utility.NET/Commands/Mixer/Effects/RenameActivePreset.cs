using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects
{
    public class RenameActivePreset : DeviceCommandBase
    {
        /// <summary>
        /// Rename the active Effect Preset.
        /// </summary>
        /// <param name="preset">The new Name of the Preset</param>
        public RenameActivePreset(string preset)
        {
            Command = new Dictionary<string, object>
            {
                ["RenameActivePreset"] = preset
            };
        }
    }
}