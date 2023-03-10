using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Settings.GuiDisplay
{
    //Path: mixer/SERIAL-NUMBER/settings/display/...
    public class GuiDisplay : INotifyPropertyChanged
    {
        private DisplayMode _compressor;
        private DisplayMode _equaliser;
        private DisplayMode _equaliserFine;
        private DisplayMode _gate;
        
        [JsonPropertyName("compressor")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayMode Compressor
        {
            get => _compressor;
            set => SetField(ref _compressor, value);
        }
        
        [JsonPropertyName("equaliser")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayMode Equaliser
        {
            get => _equaliser;
            set => SetField(ref _equaliser, value);
        }
        
        [JsonPropertyName("equaliser_fine")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayMode EqualiserFine
        {
            get => _equaliserFine;
            set => SetField(ref _equaliserFine, value);
        }
        
        [JsonPropertyName("gate")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayMode Gate
        {
            get => _gate;
            set => SetField(ref _gate, value);
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