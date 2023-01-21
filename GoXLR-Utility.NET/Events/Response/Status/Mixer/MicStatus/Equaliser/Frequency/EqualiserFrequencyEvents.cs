using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
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
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer31HzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer63HzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer125HzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer250HzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer500HzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer1KHzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer2KHzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer4KHzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer8KHzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer16KHzChanged;
        
        public void HandleEvents(string serialNumber,
            Models.Response.Status.Mixer.MicStatus.Equaliser.Frequency.Frequency frequency,
            MemberInfo memInfo, MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserEventArgs> equaliserChanged,
            EventHandler<EqualiserFrequencyEventArgs> frequencyChanged)
        {
            var doubleDeviceEventArgs = new DoubleDeviceEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Equalizer31Hz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer31Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer31Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer31HzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer63Hz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer63Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer63Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer63HzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer125Hz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer125Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer125Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer125HzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer250Hz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer250Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer250Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer250HzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer500Hz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer500Hz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer500Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer500HzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer1KHz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer1KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer1KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer1KHzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer2KHz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer2KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer2KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer2KHzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer4KHz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer4KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer4KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer4KHzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer8KHz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer8KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer8KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer8KHzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer16KHz":
                    micStatusEventArgs.Equaliser.Frequency.TypeChanged = EqualiserEnum.Equalizer16KHz;
                    micStatusEventArgs.Equaliser.Frequency.Value = doubleDeviceEventArgs.Value = frequency.Equalizer16KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.Equaliser);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.Equaliser.Frequency);
                    OnEqualizer16KHzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in EqualiserFrequencyEvents");
            }
        }
    }
}