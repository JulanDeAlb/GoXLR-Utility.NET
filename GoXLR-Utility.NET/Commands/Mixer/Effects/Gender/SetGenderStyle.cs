using System.Collections.Generic;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects.Current.Gender;

namespace GoXLR_Utility.NET.Commands.Mixer.Effects.Gender
{
    public class SetGenderStyle : CommandBase
    {
        public SetGenderStyle(GenderStyle style)
        {
            Command = new Dictionary<string, object>
            {
                ["SetGenderStyle"] = new
                {
                    style
                }
            };
        }
    }
}