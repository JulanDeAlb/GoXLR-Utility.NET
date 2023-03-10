using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Settings
{
    //Path: mixer/SERIAL-NUMBER/settings/...
    public class Settings : INotifyPropertyChanged
    {
        private GuiDisplay.GuiDisplay _display;
        private int _muteHoldDuration;
        private bool _vcMuteAlsoMuteCm;

        [JsonPropertyName("display")] 
        public GuiDisplay.GuiDisplay Display
        {
            get => _display;
            set => SetField(ref _display, value);
        }
        
        [JsonPropertyName("mute_hold_duration")]
        public int MuteHoldDuration
        {
            get => _muteHoldDuration;
            set => SetField(ref _muteHoldDuration, value);
        }
        
        /// <summary>
        /// VoiceChat mute also mutes ChatMic
        /// </summary>
        [JsonPropertyName("vc_mute_also_mute_cm")]
        public bool VcMuteAlsoMuteCm
        {
            get => _vcMuteAlsoMuteCm;
            set => SetField(ref _vcMuteAlsoMuteCm, value);
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