using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Router;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Router
{
    //Path: mixer/SERIAL-NUMBER/router/...
    
    /// <summary>
    /// <seealso cref="RouterEvents"/>
    /// </summary>
    public class Router
    {
        [JsonPropertyName("Chat")]
        public ChatRoute Chat { get; set; }
        
        [JsonPropertyName("Console")]
        public ConsoleRoute Console { get; set; }
        
        [JsonPropertyName("Game")]
        public GameRoute Game { get; set; }
        
        [JsonPropertyName("LineIn")]
        public LineInRoute LineIn { get; set; }
        
        [JsonPropertyName("Microphone")]
        public MicrophoneRoute Microphone { get; set; }
        
        [JsonPropertyName("Music")]
        public MusicRoute Music { get; set; }
        
        [JsonPropertyName("Samples")]
        public SamplesRoute Samples { get; set; }
        
        [JsonPropertyName("System")]
        public SystemRoute System { get; set; }
    }
    
    public class ChatRoute : RouterBase { }
    public class ConsoleRoute : RouterBase { }
    public class GameRoute : RouterBase { }
    public class LineInRoute : RouterBase { }
    public class MicrophoneRoute : RouterBase { }
    public class MusicRoute : RouterBase { }
    public class SamplesRoute : RouterBase { }
    public class SystemRoute : RouterBase { }
    
    public class RouterBase
    {
        [JsonPropertyName("BroadcastMix")]
        public bool BroadcastMix { get; set; }
        
        [JsonPropertyName("ChatMic")]
        public bool ChatMic { get; set; }
        
        [JsonPropertyName("Headphones")]
        public bool Headphones { get; set; }
        
        [JsonPropertyName("LineOut")]
        public bool LineOut { get; set; }
        
        [JsonPropertyName("Sampler")]
        public bool Sampler { get; set; }
    }
}