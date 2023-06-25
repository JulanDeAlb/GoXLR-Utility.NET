using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler
{
    //Path: mixer/SERIAL-NUMBER/sampler/processing_state/...
    public class ProcessingState : INotifyPropertyChanged
    { 
        private int _progress;
        private string _lastError;

        [JsonPropertyName("progress")]
        public int Progress
        {
            get => _progress;
            set => SetField(ref _progress, value);
        }

        [JsonPropertyName("last_error")]
        public string LastError
        {
            get => _lastError;
            set => SetField(ref _lastError, value);
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