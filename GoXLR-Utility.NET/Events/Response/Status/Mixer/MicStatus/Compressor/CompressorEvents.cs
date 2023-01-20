using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Compressor;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Compressor;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Compressor
{
    /// <summary>
    /// <seealso cref="Compressor"/>
    /// </summary>
    public class CompressorEvents
    {
        public event EventHandler<IntCompressorEventArgs> OnAttackChanged;
        
        public event EventHandler<IntCompressorEventArgs> OnMakeUpGainChanged;

        public event EventHandler<IntCompressorEventArgs> OnRatioChanged;
        
        public event EventHandler<IntCompressorEventArgs> OnReleaseChanged;
        
        public event EventHandler<IntCompressorEventArgs> OnThresholdChanged;

        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.Compressor.Compressor compressor, MemberInfo memInfo,
            EventHandler<CompressorEventArgs> compressorChanged, CompressorEventArgs compressorEventArgs)
        {
            var intCompressorEventArgs = new IntCompressorEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Attack":
                    compressorEventArgs.TypeChanged = CompressorEnum.Attack;
                    compressorEventArgs.Value = intCompressorEventArgs.Value = compressor.Attack;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnAttackChanged?.Invoke(this, intCompressorEventArgs);
                    break;
        
                case "MakeUpGain":
                    compressorEventArgs.TypeChanged = CompressorEnum.MakeUpGain;
                    compressorEventArgs.Value = intCompressorEventArgs.Value = compressor.MakeUpGain;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnMakeUpGainChanged?.Invoke(this, intCompressorEventArgs);
                    break;

                case "Ratio":
                    compressorEventArgs.TypeChanged = CompressorEnum.Ratio;
                    compressorEventArgs.Value = intCompressorEventArgs.Value = compressor.Ratio;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnRatioChanged?.Invoke(this, intCompressorEventArgs);
                    break;
        
                case "Release":
                    compressorEventArgs.TypeChanged = CompressorEnum.Release;
                    compressorEventArgs.Value = intCompressorEventArgs.Value = compressor.Release;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnReleaseChanged?.Invoke(this, intCompressorEventArgs);
                    break;
        
                case "Threshold":
                    compressorEventArgs.TypeChanged = CompressorEnum.Threshold;
                    compressorEventArgs.Value = intCompressorEventArgs.Value = compressor.Threshold;
                    
                    compressorChanged?.Invoke(this, compressorEventArgs);
                    OnThresholdChanged?.Invoke(this, intCompressorEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in CompressorEvents");
            }
        }
    }
}