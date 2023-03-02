using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects
{
    public class Effects : INotifyPropertyChanged
    {
        private EffectBankPresets _activePreset;
        private Current.Current _current = null!;
        private PresetNames.PresetNames _presetNames = null!;
        private bool _isEnabled;
        
        [JsonPropertyName("active_preset")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EffectBankPresets ActivePreset
        {
            get => _activePreset;
            set => SetField(ref _activePreset, value);
        }
        
        [JsonPropertyName("current")]
        public Current.Current Current
        {
            get => _current;
            set => SetField(ref _current, value);
        }

        [JsonPropertyName("preset_names")]
        public PresetNames.PresetNames PresetNames
        {
            get => _presetNames;
            set => SetField(ref _presetNames, value);
        }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetField(ref _isEnabled, value);
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