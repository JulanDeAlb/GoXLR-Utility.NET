using System.Collections.Generic;

namespace GoXLR_Utility.NET.Commands.Mixer
{
    public class LoadMicProfile : CommandBase
    {
        public LoadMicProfile(string name)
        {
            Command = new Dictionary<string, object>
            {
                ["LoadMicProfile"] = new
                {
                    name
                }
            };
        }
    }
}