using System;
using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;

namespace GoXLR_Utility.NET.Commands.Mixer.ButtonDown
{
    public class SetActiveEffectPreset : DeviceCommandBase
    {
        /// <summary>
        /// Set the Active Effect Bank Preset (Button 1-6).
        /// </summary>
        /// <param name="effectBankPresets">Effect Bank which should be active</param>
        public SetActiveEffectPreset(EffectBankPresets effectBankPresets)
        {
            Command = new Dictionary<string, object>
            {
                ["SetActiveEffectPreset"] = new object[]
                {
                    effectBankPresets.ToString()
                }
            };
        }
    }
}