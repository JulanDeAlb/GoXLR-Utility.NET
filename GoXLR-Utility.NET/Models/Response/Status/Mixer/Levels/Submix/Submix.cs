using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels.Submix
{
    //Path: mixer/SERIAL-NUMBER/levels/submix
    public class Submix : INotifyPropertyChanged
    {
        private SubmixInputs.SubmixInputs _inputs = new SubmixInputs.SubmixInputs();
        private SubmixOutputs.SubmixOutputs _outputs = new SubmixOutputs.SubmixOutputs();
        
        [JsonPropertyName("inputs")]
        public SubmixInputs.SubmixInputs Inputs
        {
            get => _inputs;
            set => SetField(ref _inputs, value);
        }
        
        [JsonPropertyName("outputs")]
        public SubmixOutputs.SubmixOutputs Outputs
        {
            get => _outputs;
            set => SetField(ref _outputs, value);
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