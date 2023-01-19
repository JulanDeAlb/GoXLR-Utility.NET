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

        public event EventHandler<BoolCoughButtonEventArgs> OnIsToggledChanged;

        public event EventHandler<CoughButtonFunctionEventArgs> OnMuteFunctionChanged;

        public event EventHandler<CoughButtonStateEventArgs> OnMuteStateChanged;

        protected internal void HandleEvents(string serialNumber,
            Models.Response.Status.Mixer.CoughButton.CoughButton coughButton, MemberInfo memInfo)
        {
            var coughButtonArgs = new CoughButtonEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (memInfo.Name)
            {
                case "IsToggle":
                    coughButtonArgs.ValueChanged = CoughButtonEnum.IsToggle;
                    coughButtonArgs.IsToggled = coughButton.IsToggle;
                    
                    OnCoughButtonChanged?.Invoke(this, coughButtonArgs);
                    OnIsToggledChanged?.Invoke(this, new BoolCoughButtonEventArgs
                    {
                        SerialNumber = serialNumber,
                        IsToggle = coughButton.IsToggle
                    });
                    break;

                case "MuteFunction":
                    coughButtonArgs.ValueChanged = CoughButtonEnum.MuteFunction;
                    coughButtonArgs.MuteFunction = coughButton.MuteFunction;
                    
                    OnCoughButtonChanged?.Invoke(this, coughButtonArgs);
                    OnMuteFunctionChanged?.Invoke(this, new CoughButtonFunctionEventArgs
                    {
                        SerialNumber = serialNumber,
                        MuteFunction = coughButton.MuteFunction
                    });
                    break;

                case "MuteState":
                    coughButtonArgs.ValueChanged = CoughButtonEnum.MuteState;
                    coughButtonArgs.MuteState = coughButton.MuteState;
                    
                    OnCoughButtonChanged?.Invoke(this, coughButtonArgs);
                    OnMuteStateChanged?.Invoke(this, new CoughButtonStateEventArgs
                    {
                        SerialNumber = serialNumber,
                        MuteState = coughButton.MuteState
                    });
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        $"The Property Name ({memInfo.Name}) is not implemented in CoughButton");
            }
        }
    }
}