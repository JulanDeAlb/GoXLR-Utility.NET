using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus
{
    /// <summary>
    /// <seealso cref="MicStatus"/>
    /// </summary>
    public class MicStatusEvents
    {
        public event EventHandler<MicStatusEventArgs> OnMicStatusChanged;
        
        public event EventHandler<> OnEqualiserChanged;
        
        public event EventHandler<> OnMiniEqualiserChanged;
        
        public event EventHandler<> OnMicCompressorChanged;
        
        public event EventHandler<> OnMicGainsChanged;
        
        public event EventHandler<> OnMicNoiseGateChanged;
        
        public event EventHandler<MicTypeEventArgs> OnMicTypeChanged;

        protected internal void HandleMicTypeEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.MicStatus micStatus, MemberInfo memInfo)
        {
            OnMicStatusChanged?.Invoke(this, new MicStatusEventArgs
            {
                SerialNumber = serialNumber,
                MicStatusEnum = MicStatusEnum.MicType
            });
            OnMicTypeChanged?.Invoke(this, new MicTypeEventArgs
            {
                SerialNumber = serialNumber,
                MicrophoneType = micStatus.MicType
            });
        }

        protected internal void HandleEqualiserEvents(string serialNumber, Equaliser equaliser, MemberInfo memInfo)
        {
            OnMicStatusChanged?.Invoke(this, new MicStatusEventArgs
            {
                SerialNumber = serialNumber,
                MicStatusEnum = MicStatusEnum.Equaliser
            });
        }
    }
}