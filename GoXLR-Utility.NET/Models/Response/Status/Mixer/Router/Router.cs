using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Router
{
    //Path: mixer/SERIAL-NUMBER/router/...
    public class Router : INotifyPropertyChanged
    {
        private RouterBase _chat;
        private RouterBase _console;
        private RouterBase _game;
        private RouterBase _lineIn;
        private RouterBase _microphone;
        private RouterBase _music;
        private RouterBase _samples;
        private RouterBase _system;
        
        [JsonPropertyName("Chat")]
        public RouterBase Chat
        {
            get => _chat;
            set => SetField(ref _chat, value);
        }
        
        [JsonPropertyName("Console")]
        public RouterBase Console
        {
            get => _console;
            set => SetField(ref _console, value);
        }
        
        [JsonPropertyName("Game")]
        public RouterBase Game
        {
            get => _game;
            set => SetField(ref _game, value);
        }
        
        [JsonPropertyName("LineIn")]
        public RouterBase LineIn
        {
            get => _lineIn;
            set => SetField(ref _lineIn, value);
        }
        
        [JsonPropertyName("Microphone")]
        public RouterBase Microphone
        {
            get => _microphone;
            set => SetField(ref _microphone, value);
        }
        
        [JsonPropertyName("Music")]
        public RouterBase Music
        {
            get => _music;
            set => SetField(ref _music, value);
        }
        
        [JsonPropertyName("Samples")]
        public RouterBase Samples
        {
            get => _samples;
            set => SetField(ref _samples, value);
        }
        
        [JsonPropertyName("System")]
        public RouterBase System
        {
            get => _system;
            set => SetField(ref _system, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
    
    public class RouterBase : INotifyPropertyChanged
    {
        private bool _broadcastMix;
        private bool _chatMic;
        private bool _headphones;
        private bool _lineOut;
        private bool _sampler;
        
        [JsonPropertyName("BroadcastMix")]
        public bool BroadcastMix
        {
            get => _broadcastMix;
            set => SetField(ref _broadcastMix, value);
        }
        
        [JsonPropertyName("ChatMic")]
        public bool ChatMic
        {
            get => _chatMic;
            set => SetField(ref _chatMic, value);
        }
        
        [JsonPropertyName("Headphones")]
        public bool Headphones
        {
            get => _headphones;
            set => SetField(ref _headphones, value);
        }
        
        [JsonPropertyName("LineOut")]
        public bool LineOut
        {
            get => _lineOut;
            set => SetField(ref _lineOut, value);
        }
        
        [JsonPropertyName("Sampler")]
        public bool Sampler
        {
            get => _sampler;
            set => SetField(ref _sampler, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}