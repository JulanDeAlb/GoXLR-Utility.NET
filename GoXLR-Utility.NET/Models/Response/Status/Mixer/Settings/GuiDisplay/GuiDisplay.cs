using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Settings.GuiDisplay
{
    public class GuiDisplay : INotifyPropertyChanged
    {
        private DisplayModeEnum _compressor;
        private DisplayModeEnum _equaliser;
        private DisplayModeEnum _equaliserFine;
        private DisplayModeEnum _gate;
        
        [JsonPropertyName("compressor")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayModeEnum Compressor
        {
            get => _compressor;
            set => SetField(ref _compressor, value);
        }
        
        [JsonPropertyName("equaliser")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayModeEnum Equaliser
        {
            get => _equaliser;
            set => SetField(ref _equaliser, value);
        }
        
        [JsonPropertyName("equaliser_fine")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayModeEnum EqualiserFine
        {
            get => _equaliserFine;
            set => SetField(ref _equaliserFine, value);
        }
        
        [JsonPropertyName("gate")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DisplayModeEnum Gate
        {
            get => _gate;
            set => SetField(ref _gate, value);
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