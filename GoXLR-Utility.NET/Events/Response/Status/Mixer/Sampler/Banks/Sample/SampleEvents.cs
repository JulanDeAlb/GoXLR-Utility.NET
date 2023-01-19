using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks.Sample;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks.Sample;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks.Sample;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Sampler.Banks.Sample
{
    /// <summary>
    /// <seealso cref="Sample"/>
    /// </summary>
    public class SampleEvents
    {
        public event EventHandler<SampleEventArgs> OnSampleChanged;
        
        public event EventHandler<StringSampleEventArgs> OnNameChanged;
        
        public event EventHandler<DoubleSampleEventArgs> OnStartPctChanged;
        
        public event EventHandler<DoubleSampleEventArgs> OnStopPctChanged;

        protected internal void HandleEvents(string serialNumber, MemberInfo memInfo,
            EventHandler<SamplerBanksEventArgs> samplerBanksChanged,
            EventHandler<BankButtonEventArgs> samplerBankChanged,
            EventHandler<BankButtonEventArgs> samplerBankButtonChanged,
            EventHandler<BankBaseEventArgs> bankBaseChanged,
            SamplerBanksEventArgs samplerBanksEventArgs,
            Models.Response.Status.Mixer.Sampler.Banks.Sample.Sample sample)
        {
            samplerBanksEventArgs.BankButton.BankBase.TypeChanged = BankBaseEnum.SampleValue;
            samplerBanksEventArgs.BankButton.BankBase.SampleValue = new SampleEventArgs
            {
                SerialNumber = serialNumber
            };
                    
            switch (memInfo.Name)
            {
                case "Name":
                    samplerBanksEventArgs.BankButton.BankBase.TypeChanged = BankBaseEnum.SampleValue;
                    samplerBanksEventArgs.BankButton.BankBase.SampleValue.TypeChanged = SampleEnum.Name;
                    samplerBanksEventArgs.BankButton.BankBase.SampleValue.Name = new StringSampleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = sample.Name
                    };

                    samplerBanksChanged?.Invoke(this, samplerBanksEventArgs);
                    samplerBankChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    samplerBankButtonChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    bankBaseChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase);
                    OnSampleChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase.SampleValue);
                    OnNameChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase.SampleValue.Name);
                    break;
                        
                case "StartPct":
                    samplerBanksEventArgs.BankButton.BankBase.TypeChanged = BankBaseEnum.SampleValue;
                    samplerBanksEventArgs.BankButton.BankBase.SampleValue.TypeChanged = SampleEnum.StartPct;
                    samplerBanksEventArgs.BankButton.BankBase.SampleValue.Pct = new DoubleSampleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = sample.StartPct
                    };

                    samplerBanksChanged?.Invoke(this, samplerBanksEventArgs);
                    samplerBankChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    samplerBankButtonChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    bankBaseChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase);
                    OnSampleChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase.SampleValue);
                    OnStartPctChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase.SampleValue.Pct);
                    break;
                        
                case "StopPct":
                    samplerBanksEventArgs.BankButton.BankBase.TypeChanged = BankBaseEnum.SampleValue;
                    samplerBanksEventArgs.BankButton.BankBase.SampleValue.TypeChanged = SampleEnum.StopPct;
                    samplerBanksEventArgs.BankButton.BankBase.SampleValue.Pct = new DoubleSampleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = sample.StopPct
                    };

                    samplerBanksChanged?.Invoke(this, samplerBanksEventArgs);
                    samplerBankChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    samplerBankButtonChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    bankBaseChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase);
                    OnSampleChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase.SampleValue);
                    OnStopPctChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase.SampleValue.Pct);
                    break;
                        
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in SamplerBankBaseButtonEvents (Sample != null)");
            }
        }
    }
}