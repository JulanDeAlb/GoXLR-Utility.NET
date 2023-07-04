using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Animatins;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Animations
{
    public class SetAnimationWaterfall : DeviceCommandBase
    {
        /// <summary>
        /// Set the Animation Waterfall direction.
        /// </summary>
        /// <param name="direction">The Watterfall direction</param>
        public SetAnimationWaterfall(WaterfallDirection direction)
        {
            Command = new Dictionary<string, object>
            {
                ["SetAnimationWaterfall"] = direction.ToString()
            };
        }
    }
}