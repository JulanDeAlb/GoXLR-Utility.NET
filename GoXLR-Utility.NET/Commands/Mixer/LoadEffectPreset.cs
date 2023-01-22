using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer
{
    public class LoadEffectPreset : CommandBase
    {
        public LoadEffectPreset(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["LoadEffectPreset"] = new
                {
                    name
                }
            };
        }
    }
}