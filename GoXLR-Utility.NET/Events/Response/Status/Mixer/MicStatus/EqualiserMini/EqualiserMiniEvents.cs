using System;
using System.Reflection;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Frequency;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.EqualiserMini.Gain;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.EqualiserMini
{
    /// <summary>
    /// <seealso cref="EqualiserMini"/>
    /// </summary>
    public class EqualiserMiniEvents
    {
        public EqualiserMiniGainEvents GainMini = new EqualiserMiniGainEvents();
        public EqualiserMiniFrequencyEvents FrequencyMini = new EqualiserMiniFrequencyEvents();
        
        public event EventHandler<EqualiserMiniGainEventArgs> OnGainMiniChanged;
        public event EventHandler<EqualiserMiniFrequencyEventArgs> OnFrequencyMiniChanged;

        public void HandleMiniGainEvents(string serialNumber, GainMini gainMini,
            MemberInfo memInfo, MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserMiniEventArgs> equaliserChanged)
        {
            GainMini.HandleEvents(serialNumber, gainMini, memInfo, micStatusEventArgs, micStatusChanged, equaliserChanged, OnGainMiniChanged);
        }

        public void HandleMiniFrequencyEvents(string serialNumber, FrequencyMini frequencyMini,
            MemberInfo memInfo, MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserMiniEventArgs> equaliserChanged)
        {
            FrequencyMini.HandleEvents(serialNumber, frequencyMini, memInfo, micStatusEventArgs, micStatusChanged, equaliserChanged, OnFrequencyMiniChanged);
        }
    }
}