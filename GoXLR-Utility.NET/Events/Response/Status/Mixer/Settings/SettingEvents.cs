using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Settings;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Settings.Display;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Settings;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Settings
{
    /// <summary>
    /// <seealso cref="Settings"/>
    /// </summary>
    public class SettingEvents
    {
        public GuiDisplayEvents GuiDisplay = new GuiDisplayEvents();

        public event EventHandler<SettingEventArgs> OnSettingsChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnMuteHoldDurationChanged;
        
        public event EventHandler<BoolDeviceEventArgs> OnVcMuteAlsoMuteCmChanged;

        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.Settings.Settings settings, MemberInfo memInfo)
        {
            var settingEventArgs = new SettingEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "MuteHoldDuration":
                    settingEventArgs.TypeChanged = SettingsEnum.MuteHoldDuration;
                    settingEventArgs.IntValue = settings.MuteHoldDuration;
                    OnSettingsChanged?.Invoke(this, settingEventArgs);
                    OnMuteHoldDurationChanged?.Invoke(this, new IntDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = settings.MuteHoldDuration
                    });
                    break;
                
                case "VcMuteAlsoMuteCm":
                    settingEventArgs.TypeChanged = SettingsEnum.VcMuteAlsoMuteCm;
                    settingEventArgs.BoolValue = settings.VcMuteAlsoMuteCm;
                    OnSettingsChanged?.Invoke(this, settingEventArgs);
                    OnVcMuteAlsoMuteCmChanged?.Invoke(this, new BoolDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = settings.VcMuteAlsoMuteCm
                    });
                    break;
                
                case "Display":
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ");
            }
        }
    }
}