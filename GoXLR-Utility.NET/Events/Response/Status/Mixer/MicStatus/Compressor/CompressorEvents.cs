using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Compressor;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Compressor
{
    /// <summary>
    /// <seealso cref="Compressor"/>
    /// </summary>
    public class CompressorEvents
    {
        public event EventHandler<IntDeviceEventArgs> OnAttackChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnMakeUpGainChanged;

        public event EventHandler<IntDeviceEventArgs> OnRatioChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnReleaseChanged;
        
        public event EventHandler<IntDeviceEventArgs> OnThresholdChanged;

        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.Compressor.Compressor compressor, MemberInfo memInfo,
            EventHandler<CompressorEventArgs> compressorChanged, CompressorEventArgs compressorEventArgs)
        {
            var intDeviceEventArgs = new IntDeviceEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Attack":
                    compressorEventArgs.TypeChanged = CompressorEnum.Attack;
                    compressorEventArgs.Value = intDeviceEventArgs.Value = compressor.Attack;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnAttackChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "MakeUpGain":
                    compressorEventArgs.TypeChanged = CompressorEnum.MakeUpGain;
                    compressorEventArgs.Value = intDeviceEventArgs.Value = compressor.MakeUpGain;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnMakeUpGainChanged?.Invoke(this, intDeviceEventArgs);
                    break;

                case "Ratio":
                    compressorEventArgs.TypeChanged = CompressorEnum.Ratio;
                    compressorEventArgs.Value = intDeviceEventArgs.Value = compressor.Ratio;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnRatioChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Release":
                    compressorEventArgs.TypeChanged = CompressorEnum.Release;
                    compressorEventArgs.Value = intDeviceEventArgs.Value = compressor.Release;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnReleaseChanged?.Invoke(this, intDeviceEventArgs);
                    break;
        
                case "Threshold":
                    compressorEventArgs.TypeChanged = CompressorEnum.Threshold;
                    compressorEventArgs.Value = intDeviceEventArgs.Value = compressor.Threshold;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnThresholdChanged?.Invoke(this, intDeviceEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in CompressorEvents");
            }
        }
    }
}