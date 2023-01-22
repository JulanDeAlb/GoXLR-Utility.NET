using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer
{
    public class LoadProfile : CommandBase
    {
        public LoadProfile(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["LoadProfile"] = new
                {
                    name
                }
            };
        }
    }
}