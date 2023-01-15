using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Frequency;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Frequency;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Equaliser.Frequency
{
    /// <summary>
    /// <seealso cref="Frequency"/>
    /// </summary>
    public class EqualiserFrequencyEvents
    {
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer31HzChanged;
        
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer63HzChanged;
        
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer125HzChanged;
        
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer250HzChanged;
        
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer500HzChanged;
        
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer1KHzChanged;
        
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer2KHzChanged;
        
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer4KHzChanged;
        
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer8KHzChanged;
        
        public event EventHandler<SpecificEqualiserFrequencyEventArgs> OnEqualizer16KHzChanged;
        
        public void HandleEvents(string serialNumber,
            Models.Response.Status.Mixer.MicStatus.Equaliser.Frequency.Frequency frequency,
            MemberInfo memInfo, MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserEventArgs> equaliserChanged,
            EventHandler<EqualiserFrequencyEventArgs> frequencyChanged)
        {
            var specEqualiserEventArgs = new SpecificEqualiserFrequencyEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Equalizer31Hz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer31Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer31Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer31HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer63Hz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer63Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer63Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer63HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer125Hz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer125Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer125Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer125HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer250Hz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer250Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer250Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer250HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer500Hz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer500Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer500Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer500HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer1KHz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer1KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer1KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer1KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer2KHz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer2KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer2KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer2KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer4KHz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer4KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer4KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer4KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer8KHz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer8KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer8KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer8KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer16KHz":
                    micStatusEventArgs.Equaliser.Frequency.ValueChanged = EqualiserEnum.Equalizer16KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = specEqualiserEventArgs.Value = frequency.Equalizer16KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer16KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in EqualiserFrequencyEvents");
            }
        }
    }
}