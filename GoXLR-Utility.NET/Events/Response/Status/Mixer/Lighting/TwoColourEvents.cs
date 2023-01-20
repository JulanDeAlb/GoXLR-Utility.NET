using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting
{
    public class TwoColourEvents
    {
        public event EventHandler<StringTwoColourEventArgs> OnColourOneChanged;
        public event EventHandler<StringTwoColourEventArgs> OnColourTwoChanged;
        
        protected internal void HandleEvents(string serialNumber, TwoColour twoColour, MemberInfo memInfo)
        {
            var twoColourEventArgs = new TwoColourEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "ColourOne":
                    twoColourEventArgs.TypeChanged = TwoColourEnum.ColourOne;
                    twoColourEventArgs.StringValue = twoColour.ColourOne;
                    
                    OnColourOneChanged?.Invoke(this, new StringTwoColourEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = twoColour.ColourOne
                    });
                    break;
                
                case "ColourTwo":
                    twoColourEventArgs.TypeChanged = TwoColourEnum.ColourTwo;
                    twoColourEventArgs.StringValue = twoColour.ColourTwo;

                    OnColourTwoChanged?.Invoke(this, new StringTwoColourEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = twoColour.ColourTwo
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in TwoColourEvents");
            }
        }
    }
}