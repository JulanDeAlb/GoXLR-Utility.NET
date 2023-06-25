using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler
{
    //Path: mixer/SERIAL-NUMBER/sampler/...
    public class Sampler : INotifyPropertyChanged
    { 
        private SamplerBank _activeBank;
        private bool _clearActive;
        private ProcessingState _processingState;
        private int _recordBuffer;
        private Banks.SamplerBanks _samplerBanks;

        [JsonPropertyName("active_bank")]
        public SamplerBank ActiveBank
        {
            get => _activeBank;
            set => SetField(ref _activeBank, value);
        }

        [JsonPropertyName("clear_active")]
        public bool ClearActive
        {
            get => _clearActive;
            set => SetField(ref _clearActive, value);
        }

        [JsonPropertyName("processing_state")]
        public ProcessingState ProcessingState
        {
            get => _processingState;
            set => SetField(ref _processingState, value);
        }

        [JsonPropertyName("record_buffer")]
        public int RecordBuffer
        {
            get => _recordBuffer;
            set => SetField(ref _recordBuffer, value);
        }

        [JsonPropertyName("banks")]
        public Banks.SamplerBanks SamplerBanks
        {
            get => _samplerBanks;
            set => SetField(ref _samplerBanks, value);
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