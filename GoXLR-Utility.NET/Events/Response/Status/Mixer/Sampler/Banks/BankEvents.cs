using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Sampler.Banks
{
    /// <summary>
    /// <seealso cref="BankBaseButton"/>
    /// </summary>
    public class BankEvents
    {
        public event EventHandler<BankEventArgs> OnBankChanged;
        
        public event EventHandler<BankFunctionEventArgs> OnFunctionChanged;
        
        public event EventHandler<BankIsPlayingEventArgs> OnIsPlayingChanged;
        
        public event EventHandler<BankOrderEventArgs> OnOrderChanged;
        
        public event EventHandler<BankSamplesEventArgs> OnSamplesChanged;

        protected internal void HandleEvents(string serialNumber, BankBaseButton bankBaseButton, MemberInfo memInfo)
        {
            var bankEventArgs = new BankEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Function":
                    bankEventArgs.BankEnum = BankEnum.Function;
                    bankEventArgs.Function = bankBaseButton.Function;
                    OnBankChanged?.Invoke(this, bankEventArgs);
                    OnFunctionChanged?.Invoke(this, new BankFunctionEventArgs
                    {
                        SerialNumber = serialNumber,
                    });
                    break;
                
                case "IsPlaying":
                    bankEventArgs.BankEnum = BankEnum.IsPlaying;
                    bankEventArgs.IsPlaying = bankBaseButton.IsPlaying;
                    OnBankChanged?.Invoke(this, bankEventArgs);
                    OnIsPlayingChanged?.Invoke(this, new BankIsPlayingEventArgs
                    {
                        SerialNumber = serialNumber,
                    });
                    break;
                
                case "Order":
                    bankEventArgs.BankEnum = BankEnum.Order;
                    bankEventArgs.Order = bankBaseButton.Order;
                    OnBankChanged?.Invoke(this, bankEventArgs);
                    OnOrderChanged?.Invoke(this, new BankOrderEventArgs
                    {
                        SerialNumber = serialNumber,
                    });
                    break;
                
                case "Samples":
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in BankEvents");
            }
        }
    }
}