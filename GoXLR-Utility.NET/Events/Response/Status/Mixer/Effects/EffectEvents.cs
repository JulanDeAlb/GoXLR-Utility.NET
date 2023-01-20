using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.PresetNames;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.Current;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.PresetNames;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects
{
    public class EffectEvents
    {
        public CurrentEffectEvents Current = new CurrentEffectEvents();
        public PresetNameEvents PresetNames = new PresetNameEvents();
        
        public event EventHandler<EffectEventArgs> OnEffectsChanged;
        public event EventHandler<ActivePresetEventArgs> OnActivePresetChanged;
        public event EventHandler<CurrentEffectEventArgs> OnCurrentEffectChanged;
        public event EventHandler<PresetNameEventArgs> OnPresetNamesChanged;
        public event EventHandler<BoolEffectEventArgs> OnEffectEnabledChanged;
        
        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.Effects.Effects effects, MemberInfo memInfo)
        {
            var effectEventArgs = new EffectEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "ActivePreset":
                    effectEventArgs.TypeChanged = EffectEnum.ActivePreset;
                    effectEventArgs.ActivePreset = new ActivePresetEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effects.ActivePreset
                    };
                    OnEffectsChanged?.Invoke(this, effectEventArgs);
                    OnActivePresetChanged?.Invoke(this, effectEventArgs.ActivePreset);
                    break;

                case "IsEnabled":
                    effectEventArgs.TypeChanged = EffectEnum.IsEnabled;
                    effectEventArgs.Enabled = new BoolEffectEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = effects.IsEnabled
                    };
                    OnEffectsChanged?.Invoke(this, effectEventArgs);
                    OnEffectEnabledChanged?.Invoke(this, effectEventArgs.Enabled);
                    break;
                
                default:
                    var type = effects.GetType();
                    throw new ArgumentOutOfRangeException(
                        $"Type out of Range in EffectEvents: {type.Name} | Path: {type.FullName}");
            }
        }

        protected internal void HandleCurrentEffectEvents(string serialNumber, object myClass, MemberInfo memInfo)
        {
            var effectEventArgs = new EffectEventArgs
            {
                SerialNumber = serialNumber,
                TypeChanged = EffectEnum.Current
            };
            
            Current.HandleEvents(serialNumber, myClass, memInfo, OnEffectsChanged, OnCurrentEffectChanged, effectEventArgs);
        }

        protected internal void HandlePresetNamesEffectEvents(string serialNumber, Models.Response.Status.Mixer.Effects.PresetNames.PresetNames presetNames, MemberInfo memInfo)
        {
            var effectEventArgs = new EffectEventArgs
            {
                SerialNumber = serialNumber,
                TypeChanged = EffectEnum.PresetNames
            };
            
            PresetNames.HandleEvents(serialNumber, presetNames, memInfo, OnEffectsChanged, OnPresetNamesChanged, effectEventArgs);
        }
    }
}