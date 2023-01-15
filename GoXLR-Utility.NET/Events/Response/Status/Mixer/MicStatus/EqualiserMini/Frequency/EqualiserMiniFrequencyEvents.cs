using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;
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
        public event EventHandler<SpecificEqualiserMiniFrequencyEventArgs> OnEqualizer90HzChanged;
        
        public event EventHandler<SpecificEqualiserMiniFrequencyEventArgs> OnEqualizer250HzChanged;
        
        public event EventHandler<SpecificEqualiserMiniFrequencyEventArgs> OnEqualizer500HzChanged;
        
        public event EventHandler<SpecificEqualiserMiniFrequencyEventArgs> OnEqualizer1KHzChanged;
        
        public event EventHandler<SpecificEqualiserMiniFrequencyEventArgs> OnEqualizer3KHzChanged;
        
        public event EventHandler<SpecificEqualiserMiniFrequencyEventArgs> OnEqualizer8KHzChanged;
        
        public void HandleEvents(string serialNumber,
            FrequencyMini frequency,
            MemberInfo memInfo, MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserMiniEventArgs> equaliserChanged,
            EventHandler<EqualiserMiniFrequencyEventArgs> frequencyChanged)
        {
            var specEqualiserEventArgs = new SpecificEqualiserMiniFrequencyEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Equalizer90Hz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.ValueChanged = EqualiserMiniEnum.Equalizer90Hz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = specEqualiserEventArgs.Value = frequency.Equalizer90Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer90HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer250Hz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.ValueChanged = EqualiserMiniEnum.Equalizer250Hz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = specEqualiserEventArgs.Value = frequency.Equalizer250Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer250HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer500Hz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.ValueChanged = EqualiserMiniEnum.Equalizer500Hz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = specEqualiserEventArgs.Value = frequency.Equalizer500Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer500HzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer1KHz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.ValueChanged = EqualiserMiniEnum.Equalizer1KHz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = specEqualiserEventArgs.Value = frequency.Equalizer1KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer1KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer3KHz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.ValueChanged = EqualiserMiniEnum.Equalizer3KHz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = specEqualiserEventArgs.Value = frequency.Equalizer3KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer3KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;
        
                case "Equalizer8KHz":
                    micStatusEventArgs.EqualiserMini.FrequencyMini.ValueChanged = EqualiserMiniEnum.Equalizer8KHz;
                    micStatusEventArgs.EqualiserMini.FrequencyMini.Value = specEqualiserEventArgs.Value = frequency.Equalizer8KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    frequencyChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.FrequencyMini);
                    OnEqualizer8KHzChanged?.Invoke(this, specEqualiserEventArgs);
                    break;

                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in EqualiserMiniFrequencyEvents");
            }
        }
    }
}