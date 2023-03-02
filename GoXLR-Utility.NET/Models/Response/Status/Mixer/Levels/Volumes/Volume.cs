using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Volumes
{
    //Path: mixer/SERIAL-NUMBER/levels/volumes/...
    public class Volume : INotifyPropertyChanged
    {
        private byte _chat;
        private byte _console;
        private byte _game;
        private byte _headphones;
        private byte _lineIn;
        private byte _lineOut;
        private byte _mic;
        private byte _micMonitor;
        private byte _music;
        private byte _sample;
        private byte _system;
        
        [JsonPropertyName("Chat")]
        public byte Chat
        {
            get => _chat;
            set => SetField(ref _chat, value);
        }
        
        [JsonPropertyName("Console")]
        public byte Console
        {
            get => _console;
            set => SetField(ref _console, value);
        }
        
        [JsonPropertyName("Game")]
        public byte Game
        {
            get => _game;
            set => SetField(ref _game, value);
        }
        
        [JsonPropertyName("Headphones")]
        public byte Headphones
        {
            get => _headphones;
            set => SetField(ref _headphones, value);
        }
        
        [JsonPropertyName("LineIn")]
        public byte LineIn
        {
            get => _lineIn;
            set => SetField(ref _lineIn, value);
        }
        
        [JsonPropertyName("LineOut")]
        public byte LineOut
        {
            get => _lineOut;
            set => SetField(ref _lineOut, value);
        }
        
        [JsonPropertyName("Mic")]
        public byte Mic
        {
            get => _mic;
            set => SetField(ref _mic, value);
        }
        
        [JsonPropertyName("MicMonitor")]
        public byte MicMonitor
        {
            get => _micMonitor;
            set => SetField(ref _micMonitor, value);
        }
        
        [JsonPropertyName("Music")]
        public byte Music
        {
            get => _music;
            set => SetField(ref _music, value);
        }
        
        [JsonPropertyName("Sample")]
        public byte Sample
        {
            get => _sample;
            set => SetField(ref _sample, value);
        }
        
        [JsonPropertyName("System")]
        public byte System
        {
            get => _system;
            set => SetField(ref _system, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            field = value;
            OnPropertyChanged(propertyName);
        }
    }
}