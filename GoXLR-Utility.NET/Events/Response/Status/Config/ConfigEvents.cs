using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Config;
using GoXLR_Utility.NET.EventArgs.Response.Status.Config;
using GoXLR_Utility.NET.Models.Response.Status.Config;

namespace GoXLR_Utility.NET.Events.Response.Status.Config
{
    /// <summary>
    /// <seealso cref="Config"/>
    /// </summary>
    public class ConfigEvents
    {
        public event EventHandler<ConfigEventArgs> OnConfigChanged; 
        public event EventHandler<BoolConfigEventArgs> OnAutoStartEnabledChanged;
        public event EventHandler<StringConfigEventArgs> OnDaemonVersionChanged;
        public event EventHandler<BoolConfigEventArgs> OnShowTrayIconChanged;

        protected internal void HandleEvents(Models.Response.Status.Config.Config config, MemberInfo memInfo)
        {
            switch (memInfo.Name)
            {
                case "AutostartEnabled":
                    OnConfigChanged?.Invoke(this, new ConfigEventArgs
                    {
                        TypeChanged = ConfigEnum.AutostartEnabled,
                        AutostartEnabled = config.AutostartEnabled
                    });
                    OnAutoStartEnabledChanged?.Invoke(this, new BoolConfigEventArgs
                    {
                        Value = config.AutostartEnabled
                    });
                    break;

                case "DaemonVersion":
                    OnConfigChanged?.Invoke(this, new ConfigEventArgs
                    {
                        TypeChanged = ConfigEnum.DaemonVersion,
                        DaemonVersion = config.DaemonVersion
                    });
                    OnDaemonVersionChanged?.Invoke(this, new StringConfigEventArgs
                    {
                        Value = config.DaemonVersion
                    });
                    break;
                
                case "ShowTrayIcon":
                    OnConfigChanged?.Invoke(this, new ConfigEventArgs
                    {
                        TypeChanged = ConfigEnum.ShowTrayIcon,
                        ShowTrayIcon = config.ShowTrayIcon
                    });
                    OnShowTrayIconChanged?.Invoke(this, new BoolConfigEventArgs
                    {
                        Value = config.ShowTrayIcon
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ConfigEvents");
            }
        }
    }
}