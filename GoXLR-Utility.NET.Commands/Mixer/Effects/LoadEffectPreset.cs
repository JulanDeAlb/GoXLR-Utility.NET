using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects
{
    public class LoadEffectPreset : DeviceCommandBase
    {
        /// <summary>
        /// Load a Effect Preset to the active Preset Slot.
        /// </summary>
        /// <param name="preset">The Preset to load</param>
        public LoadEffectPreset(string preset)
        {
            Command = new Dictionary<string, object>
            {
                ["LoadEffectPreset"] = preset
            };
        }
    }
}