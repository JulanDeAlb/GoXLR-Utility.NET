using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.EqualiserMini.Gain
{
    /// <summary>
    /// <seealso cref="GainMini"/>
    /// </summary>
    public class EqualiserMiniGainEvents
    {
        public event EventHandler<IntEqualiserMiniGainEventArgs> OnEqualizer90HzChanged;
        
        public event EventHandler<IntEqualiserMiniGainEventArgs> OnEqualizer250HzChanged;
        
        public event EventHandler<IntEqualiserMiniGainEventArgs> OnEqualizer500HzChanged;
        
        public event EventHandler<IntEqualiserMiniGainEventArgs> OnEqualizer1KHzChanged;
        
        public event EventHandler<IntEqualiserMiniGainEventArgs> OnEqualizer3KHzChanged;
        
        public event EventHandler<IntEqualiserMiniGainEventArgs> OnEqualizer8KHzChanged;
        
        public void HandleEvents(string serialNumber, GainMini gainMini,
            MemberInfo memInfo,
            MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserMiniEventArgs> equaliserChanged,
            EventHandler<EqualiserMiniGainEventArgs> gainChanged)
        {
            var intEqualiserMiniGainEventArgs = new IntEqualiserMiniGainEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Equalizer90Hz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer90Hz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intEqualiserMiniGainEventArgs.Value = gainMini.Equalizer90Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer90HzChanged?.Invoke(this, intEqualiserMiniGainEventArgs);
                    break;
        
                case "Equalizer250Hz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer250Hz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intEqualiserMiniGainEventArgs.Value = gainMini.Equalizer250Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer250HzChanged?.Invoke(this, intEqualiserMiniGainEventArgs);
                    break;
        
                case "Equalizer500Hz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer500Hz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intEqualiserMiniGainEventArgs.Value = gainMini.Equalizer500Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer500HzChanged?.Invoke(this, intEqualiserMiniGainEventArgs);
                    break;
        
                case "Equalizer1KHz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer1KHz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intEqualiserMiniGainEventArgs.Value = gainMini.Equalizer1KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer1KHzChanged?.Invoke(this, intEqualiserMiniGainEventArgs);
                    break;
        
                case "Equalizer3KHz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer3KHz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intEqualiserMiniGainEventArgs.Value = gainMini.Equalizer3KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer3KHzChanged?.Invoke(this, intEqualiserMiniGainEventArgs);
                    break;
        
                case "Equalizer8KHz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer8KHz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intEqualiserMiniGainEventArgs.Value = gainMini.Equalizer8KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer8KHzChanged?.Invoke(this, intEqualiserMiniGainEventArgs);
                    break;

                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in EqualiserMinigainEvents");
            }
        }
    }
}