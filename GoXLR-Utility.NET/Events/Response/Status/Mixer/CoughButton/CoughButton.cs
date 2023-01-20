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
                    coughButtonArgs.TypeChanged = CoughButtonEnum.IsToggle;
                    coughButtonArgs.BoolValue = coughButton.IsToggle;
                    
                    OnCoughButtonChanged?.Invoke(this, coughButtonArgs);
                    OnIsToggledChanged?.Invoke(this, new BoolCoughButtonEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = coughButton.IsToggle
                    });
                    break;

                case "MuteFunction":
                    coughButtonArgs.TypeChanged = CoughButtonEnum.MuteFunction;
                    coughButtonArgs.FunctionValue = coughButton.MuteFunction;
                    
                    OnCoughButtonChanged?.Invoke(this, coughButtonArgs);
                    OnMuteFunctionChanged?.Invoke(this, new CoughButtonFunctionEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = coughButton.MuteFunction
                    });
                    break;

                case "MuteState":
                    coughButtonArgs.TypeChanged = CoughButtonEnum.MuteState;
                    coughButtonArgs.StateValue = coughButton.MuteState;
                    
                    OnCoughButtonChanged?.Invoke(this, coughButtonArgs);
                    OnMuteStateChanged?.Invoke(this, new CoughButtonStateEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = coughButton.MuteState
                    });
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        $"The Property Name ({memInfo.Name}) is not implemented in CoughButton");
            }
        }
    }
}