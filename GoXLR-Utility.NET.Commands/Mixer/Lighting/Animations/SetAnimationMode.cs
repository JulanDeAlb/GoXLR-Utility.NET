using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting.Animatins;

namespace GoXLR_Utility.NET.Commands.Mixer.Lighting.Animations
{
    public class SetAnimationMode : DeviceCommandBase
    {
        /// <summary>
        /// Set the Animation Mode.
        /// </summary>
        /// <param name="mode">The Animation Mode</param>
        public SetAnimationMode(AnimationMode mode)
        {
            Command = new Dictionary<string, object>
            {
                ["SetAnimationMode"] = mode.ToString()
            };
        }
    }
}