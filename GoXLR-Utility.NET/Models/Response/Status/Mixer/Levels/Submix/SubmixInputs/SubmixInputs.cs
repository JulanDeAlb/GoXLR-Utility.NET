using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Submix.SubmixInputs
{
    //Path: mixer/SERIAL-NUMBER/levels/submix/inputs
    public class SubmixInputs : INotifyPropertyChanged
    {
        private SubmixInput _chat = new SubmixInput();
        private SubmixInput _console = new SubmixInput();
        private SubmixInput _game = new SubmixInput();
        private SubmixInput _lineIn = new SubmixInput();
        private SubmixInput _mic = new SubmixInput();
        private SubmixInput _music = new SubmixInput();
        private SubmixInput _sample = new SubmixInput();
        private SubmixInput _system = new SubmixInput();

        [JsonPropertyName("Chat")]
        public SubmixInput Chat
        {
            get => _chat;
            set => SetField(ref _chat, value);
        }

        [JsonPropertyName("Console")]
        public SubmixInput Console
        {
            get => _console;
            set => SetField(ref _console, value);
        }

        [JsonPropertyName("Game")]
        public SubmixInput Game
        {
            get => _game;
            set => SetField(ref _game, value);
        }

        [JsonPropertyName("LineIn")]
        public SubmixInput LineIn
        {
            get => _lineIn;
            set => SetField(ref _lineIn, value);
        }

        [JsonPropertyName("Mic")]
        public SubmixInput Mic
        {
            get => _mic;
            set => SetField(ref _mic, value);
        }

        [JsonPropertyName("Music")]
        public SubmixInput Music
        {
            get => _music;
            set => SetField(ref _music, value);
        }

        [JsonPropertyName("Sample")]
        public SubmixInput Sample
        {
            get => _sample;
            set => SetField(ref _sample, value);
        }

        [JsonPropertyName("System")]
        public SubmixInput System
        {
            get => _system;
            set => SetField(ref _system, value);
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            field = value;
            OnPropertyChanged(propertyName);
        }
    }
}