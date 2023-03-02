using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting
{
    public class TwoColour : INotifyPropertyChanged
    {
        private string _colourOne = null!;
        private string _colourTwo = null!;
        
        [JsonPropertyName("colour_one")]
        public string ColourOne
        {
            get => _colourOne;
            set => SetField(ref _colourOne, value);
        }
        
        [JsonPropertyName("colour_two")]
        public string ColourTwo
        {
            get => _colourTwo;
            set => SetField(ref _colourTwo, value);
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

    public class ThreeColour : INotifyPropertyChanged
    {
        private string _colourOne = null!;
        private string _colourTwo = null!;
        private string _colourThree = null!;
        
        [JsonPropertyName("colour_one")]
        public string ColourOne
        {
            get => _colourOne;
            set => SetField(ref _colourOne, value);
        }
        
        [JsonPropertyName("colour_two")]
        public string ColourTwo
        {
            get => _colourTwo;
            set => SetField(ref _colourTwo, value);
        }
        
        [JsonPropertyName("colour_three")]
        public string ColourThree
        {
            get => _colourThree;
            set => SetField(ref _colourThree, value);
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
    
    public class OneColour : INotifyPropertyChanged
    {
        private string _colourOne = null!;
        
        [JsonPropertyName("colour_one")]
        public string ColourOne
        {
            get => _colourOne;
            set => SetField(ref _colourOne, value);
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