using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency
{
    /// <summary>
    /// <seealso cref="FrequencyMini"/>
    /// </summary>
    public class EqualiserMiniFrequencyEvents
    {
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer90HzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer250HzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer500HzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer1KHzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer3KHzChanged;
        
        public event EventHandler<DoubleDeviceEventArgs> OnEqualizer8KHzChanged;
        
        public void HandleEvents(string serialNumber,
            FrequencyMini frequency,
            MemberInfo memInfo, MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserMiniEventArgs> equaliserChanged,
            EventHandler<EqualiserMiniFrequencyEventArgs> frequencyChanged)
        {
            var doubleDeviceEventArgs = new DoubleDeviceEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Equalizer90Hz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.TypeChanged = EqualiserMiniEnum.Equalizer90Hz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = doubleDeviceEventArgs.Value = frequency.Equalizer90Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer90HzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer250Hz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.TypeChanged = EqualiserMiniEnum.Equalizer250Hz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = doubleDeviceEventArgs.Value = frequency.Equalizer250Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer250HzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer500Hz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.TypeChanged = EqualiserMiniEnum.Equalizer500Hz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = doubleDeviceEventArgs.Value = frequency.Equalizer500Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer500HzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer1KHz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.TypeChanged = EqualiserMiniEnum.Equalizer1KHz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = doubleDeviceEventArgs.Value = frequency.Equalizer1KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer1KHzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer3KHz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.TypeChanged = EqualiserMiniEnum.Equalizer3KHz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = doubleDeviceEventArgs.Value = frequency.Equalizer3KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer3KHzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;
        
                case "Equalizer8KHz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.TypeChanged = EqualiserMiniEnum.Equalizer8KHz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = doubleDeviceEventArgs.Value = frequency.Equalizer8KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer8KHzChanged?.Invoke(this, doubleDeviceEventArgs);
                    break;

                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in EqualiserMiniFrequencyEvents");
            }
        }
    }
}