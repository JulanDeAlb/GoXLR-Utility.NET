using System;
using System.Reflection;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Router;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Router;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Router
{
    /// <summary>
    /// <seealso cref="Router"/>
    /// </summary>
    public class RouterEvents
    {
        public event EventHandler<RouterEventArgs> OnRoutingChanged;

        protected internal void HandleEvents(string serialNumber, object parentClass, MemberInfo memInfo, bool value)
        {
            var parentName = parentClass.GetType().Name.Replace("Route", "");

            if (!Enum.TryParse(parentName, out InputDevice input) || !Enum.TryParse(memInfo.Name, out OutputDevice output))
                throw new ArgumentException($"The OutputDevice Enum couldn't be parsed: {memInfo.Name}");
            
            OnRoutingChanged?.Invoke(this, new RouterEventArgs
            {
                SerialNumber = serialNumber,
                Input = input,
                Output = output,
                IsEnabled = value
            });
        }
    }
}