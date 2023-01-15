using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Sampler.Banks;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Sampler.Banks.Sample;
using GoXLR_Utility.NET.Models.Patch;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Sampler.Banks;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Sampler.Banks
{
    /// <summary>
    /// <seealso cref="SamplerBanks"/>
    /// </summary>
    public class SamplerBankEvents
    {
        public SamplerBankBaseEvents A = new SamplerBankBaseEvents();
        public SamplerBankBaseEvents B = new SamplerBankBaseEvents();
        public SamplerBankBaseEvents C = new SamplerBankBaseEvents();
        
        public event EventHandler<SamplerBanksEventArgs> OnSamplerBanksChanged;

        protected internal void HandleEvents(string serialNumber, SamplerBankBase samplerBankBase,
            BankBaseButton bankBaseButton,
            MemberInfo memInfo, OpPatchEnum patchOp, int lastIndex,
            Models.Response.Status.Mixer.Sampler.Banks.Sample.Sample sample)
        {
            var samplerBankEventArgs = new SamplerBanksEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (samplerBankBase)
            {
                case SamplerBankA _:
                    samplerBankEventArgs.TypeChanged = SamplerBank.A;
                    A.HandleEvents(serialNumber, bankBaseButton, memInfo, OnSamplerBanksChanged,
                        samplerBankEventArgs, patchOp, lastIndex, sample);
                    break;
                
                case SamplerBankB _:
                    samplerBankEventArgs.TypeChanged = SamplerBank.B;
                    B.HandleEvents(serialNumber, bankBaseButton, memInfo, OnSamplerBanksChanged,
                        samplerBankEventArgs, patchOp, lastIndex, sample);
                    break;
                
                case SamplerBankC _:
                    samplerBankEventArgs.TypeChanged = SamplerBank.C;
                    C.HandleEvents(serialNumber, bankBaseButton, memInfo, OnSamplerBanksChanged,
                        samplerBankEventArgs, patchOp, lastIndex, sample);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in SamplerBankEvents");
            }
        }
    }

    /// <summary>
    /// <seealso cref="SamplerBankBase"/>
    /// </summary>
    public class SamplerBankBaseEvents
    {
        public SamplerBankBaseButtonEvents BottomLeft = new SamplerBankBaseButtonEvents();
        public SamplerBankBaseButtonEvents BottomRight = new SamplerBankBaseButtonEvents();
        public SamplerBankBaseButtonEvents TopLeft = new SamplerBankBaseButtonEvents();
        public SamplerBankBaseButtonEvents TopRight = new SamplerBankBaseButtonEvents();
        
        public event EventHandler<BankButtonEventArgs> OnSamplerBankChanged;
        
        public event EventHandler<BankButtonEventArgs> OnBottomLeftChanged;
        
        public event EventHandler<BankButtonEventArgs> OnBottomRightChanged;
        
        public event EventHandler<BankButtonEventArgs> OnTopLeftChanged;
        
        public event EventHandler<BankButtonEventArgs> OnTopRightChanged;

        protected internal void HandleEvents(string serialNumber, BankBaseButton bankBaseButton, MemberInfo memInfo,
            EventHandler<SamplerBanksEventArgs> samplerBanksChanged, SamplerBanksEventArgs samplerBankEventArgs,
            OpPatchEnum patchOp, int lastIndex, Models.Response.Status.Mixer.Sampler.Banks.Sample.Sample sample)
        {
            samplerBankEventArgs.BankButton = new BankButtonEventArgs
            {
                SerialNumber = serialNumber
            };

            switch (bankBaseButton)
            {
                case BottomLeftBank bottomLeftBank:
                    samplerBankEventArgs.BankButton.TypeChanged = BankButtonEnum.BottomLeftBank;
                    
                    BottomLeft.HandleEvents(serialNumber, bottomLeftBank, memInfo, samplerBanksChanged, 
                        OnSamplerBankChanged, OnBottomLeftChanged,
                        samplerBankEventArgs, patchOp, lastIndex, sample);
                    break;
                
                case BottomRightBank bottomRightBank:
                    samplerBankEventArgs.BankButton.TypeChanged = BankButtonEnum.BottomRightBank;
                    
                    BottomRight.HandleEvents(serialNumber, bottomRightBank, memInfo, samplerBanksChanged, 
                        OnSamplerBankChanged, OnBottomRightChanged,
                        samplerBankEventArgs, patchOp, lastIndex, sample);
                    break;
                
                
                case TopLeftBank topLeftBank:
                    samplerBankEventArgs.BankButton.TypeChanged = BankButtonEnum.TopLeftBank;

                    TopLeft.HandleEvents(serialNumber, topLeftBank, memInfo, samplerBanksChanged, 
                        OnSamplerBankChanged, OnTopLeftChanged,
                        samplerBankEventArgs, patchOp, lastIndex, sample);
                    break;
                
                
                case TopRightBank topRightBank:
                    samplerBankEventArgs.BankButton.TypeChanged = BankButtonEnum.TopRightBank;

                    TopRight.HandleEvents(serialNumber, topRightBank, memInfo, samplerBanksChanged, 
                        OnSamplerBankChanged, OnTopRightChanged,
                        samplerBankEventArgs, patchOp, lastIndex, sample);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in SamplerBankBaseEvents");
            }
        }
    }

    /// <summary>
    /// <seealso cref="BankBaseButton"/>
    /// </summary>
    public class SamplerBankBaseButtonEvents
    {
        public SampleEvents Samples = new SampleEvents();
        
        public event EventHandler<BankBaseEventArgs> OnBankBaseChanged;
        
        public event EventHandler<BankFunctionEventArgs> OnFunctionChanged;
        
        public event EventHandler<BankIsPlayingEventArgs> OnIsPlayingChanged;
        
        public event EventHandler<BankOrderEventArgs> OnOrderChanged;
        
        public event EventHandler<BankSampleEventArgs> OnSamplesChanged;

        protected internal void HandleEvents(string serialNumber, BankBaseButton bankBaseButton, MemberInfo memInfo,
            EventHandler<SamplerBanksEventArgs> samplerBanksChanged,
            EventHandler<BankButtonEventArgs> samplerBankChanged,
            EventHandler<BankButtonEventArgs> samplerBankButtonChanged,
            SamplerBanksEventArgs samplerBanksEventArgs,
            OpPatchEnum patchOp, int lastIndex, Models.Response.Status.Mixer.Sampler.Banks.Sample.Sample sample)
        {
            samplerBanksEventArgs.BankButton.BankBase = new BankBaseEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Function":
                    samplerBanksEventArgs.BankButton.BankBase.TypeChanged = BankBaseEnum.Function;
                    samplerBanksEventArgs.BankButton.BankBase.Function = bankBaseButton.Function;
                    
                    samplerBanksChanged?.Invoke(this, samplerBanksEventArgs);
                    samplerBankChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    samplerBankButtonChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    OnBankBaseChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase);
                    OnFunctionChanged?.Invoke(this, new BankFunctionEventArgs
                    {
                        SerialNumber = serialNumber,
                        Function = bankBaseButton.Function
                    });
                    break;
                
                case "IsPlaying":
                    samplerBanksEventArgs.BankButton.BankBase.TypeChanged = BankBaseEnum.IsPlaying;
                    samplerBanksEventArgs.BankButton.BankBase.IsPlaying = bankBaseButton.IsPlaying;
                    
                    samplerBanksChanged?.Invoke(this, samplerBanksEventArgs);
                    samplerBankChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    samplerBankButtonChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    OnBankBaseChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase);
                    OnIsPlayingChanged?.Invoke(this, new BankIsPlayingEventArgs
                    {
                        SerialNumber = serialNumber,
                        IsPlaying = bankBaseButton.IsPlaying
                    });
                    break;
                
                case "Order":
                    samplerBanksEventArgs.BankButton.BankBase.TypeChanged = BankBaseEnum.Order;
                    samplerBanksEventArgs.BankButton.BankBase.Order = bankBaseButton.Order;
                    
                    samplerBanksChanged?.Invoke(this, samplerBanksEventArgs);
                    samplerBankChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    samplerBankButtonChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    OnBankBaseChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase);
                    OnOrderChanged?.Invoke(this, new BankOrderEventArgs
                    {
                        SerialNumber = serialNumber,
                        Order = bankBaseButton.Order
                    });
                    break;
                
                case "Samples":
                    samplerBanksEventArgs.BankButton.BankBase.TypeChanged = BankBaseEnum.SampleList;
                    samplerBanksEventArgs.BankButton.BankBase.SampleList = new BankSampleEventArgs
                    {
                        SerialNumber = serialNumber,
                        Index = lastIndex,
                        Operation = patchOp
                    };

                    if (patchOp != OpPatchEnum.Remove)
                        samplerBanksEventArgs.BankButton.BankBase.SampleList.Sample = bankBaseButton.Samples[lastIndex];
                    
                    samplerBanksChanged?.Invoke(this, samplerBanksEventArgs);
                    samplerBankChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    samplerBankButtonChanged?.Invoke(this, samplerBanksEventArgs.BankButton);
                    OnBankBaseChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase);
                    OnSamplesChanged?.Invoke(this, samplerBanksEventArgs.BankButton.BankBase.SampleList);
                    break;
                
                default:
                    if (sample == null) //It isn't a change in Sample
                        throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in SamplerBankBaseButtonEvents");

                    Samples.HandleEvents(serialNumber, memInfo,
                        samplerBanksChanged, samplerBankChanged, samplerBankButtonChanged,
                        OnBankBaseChanged, samplerBanksEventArgs, sample);
                    break;
            }
        }
    }

    
}