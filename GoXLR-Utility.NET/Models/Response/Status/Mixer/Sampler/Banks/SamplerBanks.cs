using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks
{
    public class SamplerBanks : INotifyPropertyChanged
    {
        private SamplerBankBase _samplerBankA;
        private SamplerBankBase _samplerBankB;
        private SamplerBankBase _samplerBankC;
        
        [JsonPropertyName("A")]
        public SamplerBankBase SamplerBankA
        {
            get => _samplerBankA;
            set => SetField(ref _samplerBankA, value);
        }
        
        [JsonPropertyName("B")]
        public SamplerBankBase SamplerBankB
        {
            get => _samplerBankB;
            set => SetField(ref _samplerBankB, value);
        }
        
        [JsonPropertyName("C")]
        public SamplerBankBase SamplerBankC
        {
            get => _samplerBankC;
            set => SetField(ref _samplerBankC, value);
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
    
    public class SamplerBankBase : INotifyPropertyChanged
    {
        private BankBaseButton _bottomLeft;
        private BankBaseButton _bottomRight;
        private BankBaseButton _topLeft;
        private BankBaseButton _topRight;
        
        [JsonPropertyName("BottomLeft")]
        public BankBaseButton BottomLeft
        {
            get => _bottomLeft;
            set => SetField(ref _bottomLeft, value);
        }
        
        [JsonPropertyName("BottomRight")]
        public BankBaseButton BottomRight
        {
            get => _bottomRight;
            set => SetField(ref _bottomRight, value);
        }
        
        [JsonPropertyName("TopLeft")]
        public BankBaseButton TopLeft
        {
            get => _topLeft;
            set => SetField(ref _topLeft, value);
        }
        
        [JsonPropertyName("TopRight")]
        public BankBaseButton TopRight
        {
            get => _topRight;
            set => SetField(ref _topRight, value);
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
    
    public class BankBaseButton : INotifyPropertyChanged
    {
        private SamplePlaybackMode _function;
        private bool _isPlaying;
        private SamplePlayOrder _order;
        private ObservableCollection<Sample.Sample> _samples;
        
        [JsonPropertyName("function")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SamplePlaybackMode Function
        {
            get => _function;
            set => SetField(ref _function, value);
        }
        
        [JsonPropertyName("is_playing")]
        public bool IsPlaying
        {
            get => _isPlaying;
            set => SetField(ref _isPlaying, value);
        }
        
        [JsonPropertyName("order")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SamplePlayOrder Order
        {
            get => _order;
            set => SetField(ref _order, value);
        }
        
        [JsonPropertyName("samples")]
        public ObservableCollection<Sample.Sample> Samples
        {
            get => _samples;
            set => SetField(ref _samples, value);
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