using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Gain;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Gain;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Equaliser.Gain
{
    /// <summary>
    /// <seealso cref="Gain"/>
    /// </summary>
    public class EqualiserGainEvents
    {
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer31HzChanged;
        
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer63HzChanged;
        
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer125HzChanged;
        
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer250HzChanged;
        
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer500HzChanged;
        
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer1KHzChanged;
        
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer2KHzChanged;
        
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer4KHzChanged;
        
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer8KHzChanged;
        
        public event EventHandler<SpecificEqualiserGainEventArgs> OnEqualizer16KHzChanged;
        
        public void HandleEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.Equaliser.Gain.Gain gain,
            MemberInfo memInfo,
            MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserEventArgs> equaliserChanged,
            EventHandler<EqualiserGainEventArgs> gainChanged)
        {
            var specEqualiserEventArgs = new SpecificEqualiserGainEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Equalizer31Hz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer31Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer31Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer31HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer63Hz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer63Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer63Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer63HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer125Hz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer125Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer125Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer125HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer250Hz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer250Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer250Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer250HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer500Hz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer500Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer500Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer500HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer1KHz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer1KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer1KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer1KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer2KHz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer2KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer2KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer2KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer4KHz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer4KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer4KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer4KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer8KHz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer8KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer8KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer8KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer16KHz":
                    micStatusEventArgs.Equaliser.Gain.ValueChanged = EqualiserEnum.Equalizer16KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = specEqualiserEventArgs.Value = gain.Equalizer16KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer16KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in EqualiserFrequencyEvents");
            }
        }
    }
}