using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Simple
{
    public class SimpleLight
    {
        [JsonPropertyName("Accent")]
        public Accent Accent { get; set; }
        
        [JsonPropertyName("Scribble1")]
        public Scribble1 Scribble1 { get; set; }
        
        [JsonPropertyName("Scribble2")]
        public Scribble2 Scribble2 { get; set; }
        
        [JsonPropertyName("Scribble3")]
        public Scribble3 Scribble3 { get; set; }
        
        [JsonPropertyName("Scribble4")]
        public Scribble4 Scribble4 { get; set; }
        
        [JsonPropertyName("Global")]
        public Global Global { get; set; }
    }

    public class Accent : OneColour { }
    public class Scribble1 : OneColour { }
    public class Scribble2 : OneColour { }
    public class Scribble3 : OneColour { }
    public class Scribble4 : OneColour { }
    public class Global : OneColour { }
}