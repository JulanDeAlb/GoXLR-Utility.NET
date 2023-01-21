using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
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
        public event EventHandler<IntDeviceEventArgs> OnEqualizer31HzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer63HzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer125HzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer250HzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer500HzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer1KHzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer2KHzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer4KHzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer8KHzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer16KHzChanged;
        
        public void HandleEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.Equaliser.Gain.Gain gain,
            MemberInfo memInfo,
            MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserEventArgs> equaliserChanged,
            EventHandler<EqualiserGainEventArgs> gainChanged)
        {
            var intDeviceEventArgs = new IntDeviceEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Equalizer31Hz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer31Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer31Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer31HzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer63Hz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer63Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer63Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer63HzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer125Hz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer125Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer125Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer125HzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer250Hz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer250Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer250Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer250HzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer500Hz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer500Hz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer500Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer500HzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer1KHz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer1KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer1KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer1KHzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer2KHz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer2KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer2KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer2KHzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer4KHz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer4KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer4KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer4KHzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer8KHz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer8KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer8KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer8KHzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer16KHz":
                    micStatusEventArgs.Equaliser.Gain.TypeChanged = EqualiserEnum.Equalizer16KHz;
                    micStatusEventArgs.Equaliser.Gain.Value = intDeviceEventArgs.Value = gain.Equalizer16KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    gainChanged?.Invoke(this, micStatusEventArgs.Equaliser.Gain);
                    OnEqualizer16KHzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in EqualiserFrequencyEvents");
            }
        }
    }
}