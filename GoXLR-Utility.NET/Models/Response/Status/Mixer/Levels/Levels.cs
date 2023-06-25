using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Router;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Volumes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels
{
    //Path: mixer/SERIAL-NUMBER/levels/...
    public class Levels : INotifyPropertyChanged
    {
        private sbyte _bleep;
        private sbyte _deEsser;
        private OutputDevice _outputMonitor;
        private Submix.Submix _submix = new Submix.Submix();
        private bool _submixSupported;
        private Volume _volumes;
        
        [JsonPropertyName("bleep")]
        public sbyte Bleep
        {
            get => _bleep;
            set => SetField(ref _bleep, value);
        }
        
        [JsonPropertyName("deess")]
        public sbyte DeEsser
        {
            get => _deEsser;
            set => SetField(ref _deEsser, value);
        }
        
        [JsonPropertyName("output_monitor")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OutputDevice OutputMonitor
        {
            get => _outputMonitor;
            set => SetField(ref _outputMonitor, value);
        }
        
        [JsonPropertyName("submix")]
        public Submix.Submix Submix
        {
            get => _submix;
            set
            {
                SubmixEnabled = value != null;
                
                if (SubmixEnabled)
                    SetField(ref _submix, value);
            }
        }

        public bool SubmixEnabled;

        [JsonPropertyName("submix_supported")]
        public bool SubmixSupported
        {
            get => _submixSupported;
            set => SetField(ref _submixSupported, value);
        }
        
        [JsonPropertyName("volumes")]
        public Volume Volumes
        {
            get => _volumes;
            set => SetField(ref _volumes, value);
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