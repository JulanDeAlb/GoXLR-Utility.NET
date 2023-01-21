using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Effects.PresetNames;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Effects;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Effects.PresetNames
{
    public class PresetNameEvents
    {
        public event EventHandler<StringDeviceEventArgs> OnPreset1Changed;
        public event EventHandler<StringDeviceEventArgs> OnPreset2Changed;
        public event EventHandler<StringDeviceEventArgs> OnPreset3Changed;
        public event EventHandler<StringDeviceEventArgs> OnPreset4Changed;
        public event EventHandler<StringDeviceEventArgs> OnPreset5Changed;
        public event EventHandler<StringDeviceEventArgs> OnPreset6Changed;
        
        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.Effects.PresetNames.PresetNames presetNames,
            MemberInfo memInfo, EventHandler<EffectEventArgs> effectsChanged, 
            EventHandler<PresetNameEventArgs> presetNamesChanged,
            EffectEventArgs effectEventArgs)
        {
            effectEventArgs.PresetNames = new PresetNameEventArgs
            {
                SerialNumber = serialNumber
            };

            var stringDeviceEventArgs = new StringDeviceEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (memInfo.Name)
            {
                case "Preset1":
                    effectEventArgs.PresetNames.TypeChanged = EffectBankPresets.Preset1;
                    effectEventArgs.PresetNames.Value = stringDeviceEventArgs.Value = presetNames.Preset1;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    presetNamesChanged?.Invoke(this, effectEventArgs.PresetNames);
                    OnPreset1Changed?.Invoke(this, stringDeviceEventArgs);
                    break;
                
                case "Preset2":
                    effectEventArgs.PresetNames.TypeChanged = EffectBankPresets.Preset2;
                    effectEventArgs.PresetNames.Value = stringDeviceEventArgs.Value = presetNames.Preset2;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    presetNamesChanged?.Invoke(this, effectEventArgs.PresetNames);
                    OnPreset2Changed?.Invoke(this, stringDeviceEventArgs);
                    break;
                
                case "Preset3":
                    effectEventArgs.PresetNames.TypeChanged = EffectBankPresets.Preset3;
                    effectEventArgs.PresetNames.Value = stringDeviceEventArgs.Value = presetNames.Preset3;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    presetNamesChanged?.Invoke(this, effectEventArgs.PresetNames);
                    OnPreset3Changed?.Invoke(this, stringDeviceEventArgs);
                    break;
                
                case "Preset4":
                    effectEventArgs.PresetNames.TypeChanged = EffectBankPresets.Preset4;
                    effectEventArgs.PresetNames.Value = stringDeviceEventArgs.Value = presetNames.Preset4;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    presetNamesChanged?.Invoke(this, effectEventArgs.PresetNames);
                    OnPreset4Changed?.Invoke(this, stringDeviceEventArgs);
                    break;
                
                case "Preset5":
                    effectEventArgs.PresetNames.TypeChanged = EffectBankPresets.Preset5;
                    effectEventArgs.PresetNames.Value = stringDeviceEventArgs.Value = presetNames.Preset5;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    presetNamesChanged?.Invoke(this, effectEventArgs.PresetNames);
                    OnPreset5Changed?.Invoke(this, stringDeviceEventArgs);
                    break;
                
                case "Preset6":
                    effectEventArgs.PresetNames.TypeChanged = EffectBankPresets.Preset6;
                    effectEventArgs.PresetNames.Value = stringDeviceEventArgs.Value = presetNames.Preset6;
                    
                    effectsChanged?.Invoke(this, effectEventArgs);
                    presetNamesChanged?.Invoke(this, effectEventArgs.PresetNames);
                    OnPreset6Changed?.Invoke(this, stringDeviceEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in PresetNameEvents");
            }
        }
    }
}