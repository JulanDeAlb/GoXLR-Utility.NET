using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.ShutdownCommands
{
    public class ShutdownCommands : INotifyPropertyChanged
    {
        private string _loadProfileColours;
        private bool _saveMicProfile;
        private bool _saveProfile;
        
        public string LoadProfileColours
        {
           get => _loadProfileColours;
           set => SetField(ref _loadProfileColours, value);
        }
        public bool SaveMicProfile
        {
           get => _saveMicProfile;
           set => SetField(ref _saveMicProfile, value);
        }
        public bool SaveProfile
        {
           get => _saveProfile;
           set => SetField(ref _saveProfile, value);
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