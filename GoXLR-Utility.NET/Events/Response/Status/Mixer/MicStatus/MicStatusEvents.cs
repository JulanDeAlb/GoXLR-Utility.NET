using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Frequency;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Gain;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.MicGains;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.NoiseGate;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.MicGains;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.NoiseGate;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser.Gain;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus
{
    /// <summary>
    /// <seealso cref="MicStatus"/>
    /// </summary>
    public class MicStatusEvents
    {
        public EqualiserEvents Equaliser = new EqualiserEvents();
        public EqualiserMiniEvents EqualiserMini = new EqualiserMiniEvents();
        public CompressorEvents Compressor = new CompressorEvents();
        public MicGainEvents MicGains = new MicGainEvents();
        public NoiseGateEvents NoiseGate = new NoiseGateEvents();
        
        public event EventHandler<MicStatusEventArgs> OnMicStatusChanged;
        
        public event EventHandler<EqualiserEventArgs> OnEqualiserChanged;
        
        public event EventHandler<EqualiserMiniEventArgs> OnEqualiserMiniChanged;
        
        public event EventHandler<CompressorEventArgs> OnCompressorChanged;
        
        public event EventHandler<MicGainEventArgs> OnGainsChanged;
        
        public event EventHandler<NoiseGateEventArgs> OnNoiseGateChanged;
        
        public event EventHandler<MicTypeEventArgs> OnMicTypeChanged;

        protected internal void HandleMicTypeEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.MicStatus micStatus)
        {
            var micStatusEventArgs = new MicStatusEventArgs
            {
                SerialNumber = serialNumber,
                TypeChanged = MicStatusEnum.MicType,
                MicType = new MicTypeEventArgs
                {
                    SerialNumber = serialNumber,
                    Value = micStatus.MicType
                }
            };
            
            OnMicStatusChanged?.Invoke(this, micStatusEventArgs);
            OnMicTypeChanged?.Invoke(this, micStatusEventArgs.MicType);
        }

        protected internal void HandleEqualiserEvents(string serialNumber, object myClass, MemberInfo memInfo)
        {
            var micStatusEventArgs = new MicStatusEventArgs
            {
                SerialNumber = serialNumber,
                TypeChanged = MicStatusEnum.Equaliser,
                Equaliser = new EqualiserEventArgs
                {
                    SerialNumber = serialNumber
                }
            };

            switch (myClass)
            {
                case Gain gain:
                    micStatusEventArgs.Equaliser.TypeChanged = EqualiserTypeEnum.Gain;
                    micStatusEventArgs.Equaliser.Gain = new EqualiserGainEventArgs
                    {
                        SerialNumber = serialNumber
                    };
                    Equaliser.HandleGainEvents(serialNumber, gain, memInfo, micStatusEventArgs, OnMicStatusChanged, OnEqualiserChanged);
                    break;
                
                case Frequency frequency:
                    micStatusEventArgs.Equaliser.TypeChanged = EqualiserTypeEnum.Frequency;
                    micStatusEventArgs.Equaliser.Frequency = new EqualiserFrequencyEventArgs
                    {
                        SerialNumber = serialNumber
                    };
                    Equaliser.HandleFrequencyEvents(serialNumber, frequency, memInfo, micStatusEventArgs, OnMicStatusChanged, OnEqualiserChanged);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({myClass}) is not implemented in MicStatusEvents-HandleEqualiserEvents");
            }
        }
        
        protected internal void HandleEqualiserMiniEvents(string serialNumber, object myClass, MemberInfo memInfo)
        {
            var micStatusEventArgs = new MicStatusEventArgs
            {
                SerialNumber = serialNumber,
                TypeChanged = MicStatusEnum.EqualiserMini,
                EqualiserMini = new EqualiserMiniEventArgs
                {
                    SerialNumber = serialNumber
                }
            };

            switch (myClass)
            {
                case GainMini gainMini:
                    micStatusEventArgs.EqualiserMini.TypeChanged = EqualiserTypeEnum.Gain;
                    micStatusEventArgs.EqualiserMini.GainMini = new EqualiserMiniGainEventArgs
                    {
                        SerialNumber = serialNumber
                    };
                    EqualiserMini.HandleMiniGainEvents(serialNumber, gainMini, memInfo, micStatusEventArgs, OnMicStatusChanged, OnEqualiserMiniChanged);
                    break;
                
                case FrequencyMini frequencyMini:
                    micStatusEventArgs.EqualiserMini.TypeChanged = EqualiserTypeEnum.Frequency;
                    micStatusEventArgs.EqualiserMini.FrequencyMini = new EqualiserMiniFrequencyEventArgs
                    {
                        SerialNumber = serialNumber
                    };
                    EqualiserMini.HandleMiniFrequencyEvents(serialNumber, frequencyMini, memInfo, micStatusEventArgs, OnMicStatusChanged, OnEqualiserMiniChanged);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({myClass}) is not implemented in MicStatusEvents-HandleEqualiserMiniEvents");
            }
        }

        protected internal void HandleCompressorEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.Compressor.Compressor compressor, MemberInfo memInfo)
        {
            var micStatusEventArgs = new MicStatusEventArgs
            {
                SerialNumber = serialNumber,
                TypeChanged = MicStatusEnum.Compressor,
                Compressor = new CompressorEventArgs
                {
                    SerialNumber = serialNumber
                }
            };
            
            OnMicStatusChanged?.Invoke(this, micStatusEventArgs);
            Compressor.HandleEvents(serialNumber, compressor, memInfo, OnCompressorChanged, micStatusEventArgs.Compressor);
        }

        protected internal void HandleMicGainEvents(string serialNumber,
            Models.Response.Status.Mixer.MicStatus.MicGains.MicGains micGains, MemberInfo memInfo)
        {
            var micStatusEventArgs = new MicStatusEventArgs
            {
                SerialNumber = serialNumber,
                TypeChanged = MicStatusEnum.MicType,
                MicGains = new MicGainEventArgs
                {
                    SerialNumber = serialNumber
                }
            };
            
            OnMicStatusChanged?.Invoke(this, micStatusEventArgs);
            MicGains.HandleEvents(serialNumber, micGains, memInfo, OnGainsChanged, micStatusEventArgs.MicGains);
        }
        
        protected internal void HandleNoiseGateEvents(string serialNumber,
            Models.Response.Status.Mixer.MicStatus.NoiseGate.NoiseGate noiseGate, MemberInfo memInfo)
        {
            var micStatusEventArgs = new MicStatusEventArgs
            {
                SerialNumber = serialNumber,
                TypeChanged = MicStatusEnum.MicType,
                NoiseGate = new NoiseGateEventArgs
                {
                    SerialNumber = serialNumber
                }
            };
            
            OnMicStatusChanged?.Invoke(this, micStatusEventArgs);
            NoiseGate.HandleEvents(serialNumber, noiseGate, memInfo, OnNoiseGateChanged, micStatusEventArgs.NoiseGate);
        }
    }
}