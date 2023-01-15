using System;
using System.Reflection;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Frequency;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.MicStatus.Equaliser.Gain;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Equaliser.Frequency;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Equaliser.Gain;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.MicStatus.Equaliser;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.MicStatus.Equaliser
{
    /// <summary>
    /// <seealso cref="Equaliser"/>
    /// </summary>
    public class EqualiserEvents
    {
        public EqualiserGainEvents Gain = new EqualiserGainEvents();
        public EqualiserFrequencyEvents Frequency = new EqualiserFrequencyEvents();
        
        public event EventHandler<EqualiserGainEventArgs> OnGainChanged;
        public event EventHandler<EqualiserFrequencyEventArgs> OnFrequencyChanged;

        public void HandleGainEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.Equaliser.Gain.Gain gain,
            MemberInfo memInfo, MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserEventArgs> equaliserChanged)
        {
            Gain.HandleEvents(serialNumber, gain, memInfo, micStatusEventArgs, micStatusChanged, equaliserChanged, OnGainChanged);
        }

        public void HandleFrequencyEvents(string serialNumber, Models.Response.Status.Mixer.MicStatus.Equaliser.Frequency.Frequency frequency,
            MemberInfo memInfo, MicStatusEventArgs micStatusEventArgs,
            EventHandler<MicStatusEventArgs> micStatusChanged, EventHandler<EqualiserEventArgs> equaliserChanged)
        {
            Frequency.HandleEvents(serialNumber, frequency, memInfo, micStatusEventArgs, micStatusChanged, equaliserChanged, OnFrequencyChanged);
        }
    }
}