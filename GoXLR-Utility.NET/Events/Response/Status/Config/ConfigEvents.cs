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
        public event EventHandler<AutoStartEnabledEventArgs> OnAutoStartEnabledChanged;
        public event EventHandler<DaemonVersionEventArgs> OnDaemonVersionChanged;
        public event EventHandler<ShowTrayIconEventArgs> OnShowTrayIconChanged;

        protected internal void HandleEvents(Models.Response.Status.Config.Config config, MemberInfo memInfo, object value)
        {
            switch (memInfo.Name)
            {
                case "AutostartEnabled":
                    OnConfigChanged?.Invoke(this, new ConfigEventArgs
                    {
                        ConfigEnum = ConfigEnum.AutostartEnabled,
                        AutostartEnabled = (bool) value
                    });
                    OnAutoStartEnabledChanged?.Invoke(this, new AutoStartEnabledEventArgs
                    {
                        AutoStartEnabled = (bool) value
                    });
                    break;

                case "DaemonVersion":
                    OnConfigChanged?.Invoke(this, new ConfigEventArgs
                    {
                        ConfigEnum = ConfigEnum.DaemonVersion,
                        DaemonVersion = (string) value
                    });
                    OnDaemonVersionChanged?.Invoke(this, new DaemonVersionEventArgs
                    {
                        DaemonVersion = (string) value
                    });
                    break;
                
                case "ShowTrayIcon":
                    OnConfigChanged?.Invoke(this, new ConfigEventArgs
                    {
                        ConfigEnum = ConfigEnum.ShowTrayIcon,
                        ShowTrayIcon = (bool) value
                    });
                    OnShowTrayIconChanged?.Invoke(this, new ShowTrayIconEventArgs
                    {
                        ShowTrayIcon = (bool) value
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ConfigEvents");
            }
        }
    }
}