using System;
using System.Reflection;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.PresetNames;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.PresetNames;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects.Current.EffectTypes;

namespace GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects
{
    public class Effects
    {
        [JsonPropertyName("active_preset")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EffectBankPresets ActivePreset { get; set; }
        
        [JsonPropertyName("current")]
        public Current.Current Current { get; set; }

        [JsonPropertyName("preset_names")]
        public PresetNames.PresetNames PresetNames { get; set; }
        
        [JsonPropertyName("is_enabled")]
        public bool IsEnabled { get; set; }
    }

    public class EffectEvents
    {
        public CurrentEffectEvents Current = new CurrentEffectEvents();
        public PresetNameEvents PresetNames = new PresetNameEvents();
        
        public event EventHandler<EffectEventArgs> OnEffectsChanged;
        public event EventHandler<ActivePresetEventArgs> OnActivePresetChanged;
        public event EventHandler<CurrentEffectEventArgs> OnCurrentEffectChanged;
        public event EventHandler<PresetNameEventArgs> OnPresetNamesChanged;
        public event EventHandler<EffectEnabledEventArgs> OnEffectEnabledChanged;
        
        protected virtual void HandleEvents(string serialNumber, object myClass, MemberInfo memInfo)
        {
            var effectEventArgs = new EffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (myClass)
            {
                case EffectBankPresets activePreset:
                    effectEventArgs.TypeChanged = EffectEnum.ActivePreset;
                    effectEventArgs.ActivePreset = new ActivePresetEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = activePreset
                    };
                    OnEffectsChanged?.Invoke(this, effectEventArgs);
                    OnActivePresetChanged?.Invoke(this, effectEventArgs.ActivePreset);
                    break;
                
                case Current.Current current:
                    Current.HandleEvents(serialNumber, current, memInfo, OnEffectsChanged, OnCurrentEffectChanged);
                    break;
                
                case PresetNames.PresetNames presetNames:
                    PresetNames.HandleEvents(serialNumber, presetNames, memInfo, OnEffectsChanged, OnPresetNamesChanged, effectEventArgs);
                    break;

                case bool myBool:
                    effectEventArgs.TypeChanged = EffectEnum.IsEnabled;
                    effectEventArgs.Enabled = new EffectEnabledEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = myBool
                    };
                    OnEffectsChanged?.Invoke(this, effectEventArgs);
                    OnEffectEnabledChanged?.Invoke(this, effectEventArgs.Enabled);
                    break;
                
                default:
                    var type = myClass.GetType();
                    throw new ArgumentOutOfRangeException(
                        $"Type out of Range in EffectEvents: {type.Name} | Path: {type.FullName}");
            }
        }

        protected internal void HandleCurrentEffectEvents(string serialNumber, object myClass, MemberInfo memInfo)
        {
            
        }
    }

    public class EffectEventArgs : System.EventArgs
    {
        public ActivePresetEventArgs ActivePreset { get; set; }
        
        public CurrentEffectEventArgs Current { get; set; }
        
        public EffectEnabledEventArgs Enabled { get; set; }
        
        public PresetNameEventArgs PresetNames { get; set; }
        
        public string SerialNumber { get; set; }
        
        /// <summary>
        /// Indicating which type of the Effects has been changed
        /// </summary>
        public EffectEnum TypeChanged { get; set; }
    }

    public class CurrentEffectEvents
    {
        public event EventHandler<CurrentEffectEventArgs> OnEffectChanged;
        /*public event EventHandler<EchoEventArgs> OnEchoChanged;
        public event EventHandler<GenderEventArgs> OnGenderChanged;
        public event EventHandler<HardTuneEventArgs> OnHardTuneChanged;
        public event EventHandler<MegaphoneEventArgs> OnMegaphoneChanged;
        public event EventHandler<PitchEventArgs> OnPitchChanged;
        public event EventHandler<ReverbEventArgs> OnReverbChanged;
        public event EventHandler<RobotEventArgs> OnRobotChanged;*/

        protected internal void HandleEvents(string serialNumber, object myClass, MemberInfo memInfo,
            EventHandler<EffectEventArgs> effectsChanged, EventHandler<CurrentEffectEventArgs> currentEffectChanged)
        {
            switch (myClass)
            {
                case EchoEffect echoEffect: //TODO
                    
                    break;
                
                case GenderEffect genderEffect: //TODO

                    break;
                
                case HardTuneEffect hardTuneEffect: //TODO

                    break;
                
                case MegaphoneEffect megaphoneEffect: //TODO

                    break;
                
                case PitchEffect pitchEffect: //TODO

                    break;
                
                case ReverbEffect reverbEffect: //TODO 

                    break;
                
                case RobotEffect robotEffect: //TODO

                    break;
                
                default: 
                    var type = myClass.GetType();
                    throw new ArgumentOutOfRangeException(
                        $"Type out of Range in EffectEvents (Effect): {type.Name} | Path: {type.FullName}");
            }            
        }
    }
}