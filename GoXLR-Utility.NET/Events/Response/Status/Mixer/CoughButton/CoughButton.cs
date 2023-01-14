using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.CoughButton;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.CoughButton;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.CoughButton;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.CoughButton
{
    /// <summary>
    /// <seealso cref="CoughButton"/>
    /// </summary>
    public class CoughButtonEvents
    {
        public event EventHandler<CoughButtonEventArgs> OnCoughButtonChanged;

        public event EventHandler<CoughIsToggledEventArgs> OnIsToggledChanged;

        public event EventHandler<CoughMuteFunctionEventArgs> OnMuteFunctionChanged;

        public event EventHandler<CoughMuteStateEventArgs> OnMuteStateChanged;

        protected internal void HandleEvents(string serialNumber,
            Models.Response.Status.Mixer.CoughButton.CoughButton myClass, MemberInfo memInfo)
        {
            var coughButtonArgs = new CoughButtonEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (memInfo.Name)
            {
                case "IsToggle":
                    coughButtonArgs.ValueChanged = CoughButtonEnum.IsToggle;
                    coughButtonArgs.IsToggled = myClass.IsToggle;
                    OnCoughButtonChanged?.Invoke(this, coughButtonArgs);
                    OnIsToggledChanged?.Invoke(this, new CoughIsToggledEventArgs
                    {
                        SerialNumber = serialNumber,
                        IsToggle = myClass.IsToggle
                    });
                    break;

                case "MuteFunction":
                    coughButtonArgs.ValueChanged = CoughButtonEnum.MuteFunction;
                    coughButtonArgs.MuteFunction = myClass.MuteFunction;
                    OnCoughButtonChanged?.Invoke(this, coughButtonArgs);
                    OnMuteFunctionChanged?.Invoke(this, new CoughMuteFunctionEventArgs
                    {
                        SerialNumber = serialNumber,
                        MuteFunction = myClass.MuteFunction
                    });
                    break;

                case "MuteState":
                    coughButtonArgs.ValueChanged = CoughButtonEnum.MuteState;
                    coughButtonArgs.MuteState = myClass.MuteState;
                    OnCoughButtonChanged?.Invoke(this, coughButtonArgs);
                    OnMuteStateChanged?.Invoke(this, new CoughMuteStateEventArgs
                    {
                        SerialNumber = serialNumber,
                        MuteState = myClass.MuteState
                    });
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        $"The Property Name ({memInfo.Name}) is not implemented in CoughButton");
            }
        }
    }
}