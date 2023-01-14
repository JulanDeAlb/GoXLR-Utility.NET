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

    public enum SimpleLightEnum
    {
        Accent,
        SribbleA,
        ScribbleB,
        ScribbleC,
        ScribbleD,
        Global
    }
    
    public class Accent : SimpleBase { }
    public class Scribble1 : SimpleBase { }
    public class Scribble2 : SimpleBase { }
    public class Scribble3 : SimpleBase { }
    public class Scribble4 : SimpleBase { }
    public class Global : SimpleBase { }
    
    public class SimpleBase
    {
        [JsonPropertyName("colour_one")]
        public string ColourOne { get; set; }
    }
}