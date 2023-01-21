using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
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
        public event EventHandler<IntDeviceEventArgs> OnEqualizer90HzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer250HzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer500HzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer1KHzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer3KHzChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnEqualizer8KHzChanged;
        
        public void HandleEvents(string serialNumber, GainMini gainMini,
            MemberInfo memInfo,
            MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserMiniEventArgs> equaliserChanged,
            EventHandler<EqualiserMiniGainEventArgs> gainChanged)
        {
            var intDeviceEventArgs = new IntDeviceEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Equalizer90Hz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer90Hz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intDeviceEventArgs.Value = gainMini.Equalizer90Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer90HzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer250Hz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer250Hz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intDeviceEventArgs.Value = gainMini.Equalizer250Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer250HzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer500Hz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer500Hz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intDeviceEventArgs.Value = gainMini.Equalizer500Hz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer500HzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer1KHz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer1KHz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intDeviceEventArgs.Value = gainMini.Equalizer1KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer1KHzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer3KHz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer3KHz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intDeviceEventArgs.Value = gainMini.Equalizer3KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer3KHzChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Equalizer8KHz":
                    micStatusEventArgs.EqualiserMini.GainMini.TypeChanged = EqualiserMiniEnum.Equalizer8KHz;
                    micStatusEventArgs.EqualiserMini.GainMini.Value = intDeviceEventArgs.Value = gainMini.Equalizer8KHz;
                    
                    micStatusChanged?.Invoke(this, micStatusEventArgs);
                    equaliserChanged?.Invoke(this, micStatusEventArgs.EqualiserMini);
                    gainChanged?.Invoke(this, micStatusEventArgs.EqualiserMini.GainMini);
                    OnEqualizer8KHzChanged?.Invoke(this, intDeviceEventArgs);
                    break;

                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in EqualiserMinigainEvents");
            }
        }
    }
}