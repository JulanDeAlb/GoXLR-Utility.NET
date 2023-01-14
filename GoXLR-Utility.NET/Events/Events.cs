using GoXLR_Utility.NET.Events.Response.Status.Config;
using GoXLR_Utility.NET.Events.Response.Status.Files;
using GoXLR_Utility.NET.Events.Response.Status.Mixer;
using GoXLR_Utility.NET.Events.Response.Status.Paths;

namespace GoXLR_Utility.NET.Events
{
    public class Events
    {
        public ConfigEvents Config;
        public FileEvents File;
        public MixerEvents Device;
        public PathEvents Path;

        public Events()
        {
            Config = new ConfigEvents();
            File = new FileEvents();
            Device = new MixerEvents();
            Path = new PathEvents();
        }
    }
}