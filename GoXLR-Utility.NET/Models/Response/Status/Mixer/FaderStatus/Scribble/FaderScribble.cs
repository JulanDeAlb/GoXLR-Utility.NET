using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.FaderStatus.Scribble
{
    public class FaderScribble : INotifyPropertyChanged
    {
        private string _bottomText = null!;
        private string _fileName = null!;
        private bool _inverted;
        private string _leftText = null!;
        
        [JsonPropertyName("bottom_text")]
        public string BottomText
        {
            get => _bottomText;
            set => SetField(ref _bottomText, value);
        }
        
        [JsonPropertyName("file_name")]
        public string FileName
        {
            get => _fileName;
            set => SetField(ref _fileName, value);
        }
        
        [JsonPropertyName("inverted")]
        public bool Inverted
        {
            get => _inverted;
            set => SetField(ref _inverted, value);
        }
        
        [JsonPropertyName("left_text")]
        public string LeftText
        {
            get => _leftText;
            set => SetField(ref _leftText, value);
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