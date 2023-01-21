using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Button;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Encoder;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Fader;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Lighting.Sampler;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Lighting.Encoders;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Lighting
{
    public class ThreeColourEvents {
        public event EventHandler<StringDeviceEventArgs> OnColourOneChanged;
        public event EventHandler<StringDeviceEventArgs> OnColourTwoChanged;
        public event EventHandler<StringDeviceEventArgs> OnColourThreeChanged;

        protected internal void HandleSamplerEvents(string serialNumber, ThreeColour colour, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<SamplerLightingEventArgs> samplerChanged,
            EventHandler<SamplerLightingBaseEventArgs> samplerXChanged,
            EventHandler<SamplerColourEventArgs> colourChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Sampler.Base.Colour = new SamplerColourEventArgs
            {
                SerialNumber = serialNumber,
            };
            
            switch (memInfo.Name)
            {
                case "ColourOne":
                    lightingEventArgs.Sampler.Base.Colour.TypeChanged = ThreeColourEnum.ColourOne;
                    lightingEventArgs.Sampler.Base.Colour.Value = colour.ColourOne;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    samplerChanged?.Invoke(this, lightingEventArgs.Sampler);
                    samplerXChanged?.Invoke(this, lightingEventArgs.Sampler.Base);
                    colourChanged?.Invoke(this, lightingEventArgs.Sampler.Base.Colour);
                    OnColourOneChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourOne
                    });
                    break;
                
                case "ColourTwo":
                    lightingEventArgs.Sampler.Base.Colour.TypeChanged = ThreeColourEnum.ColourTwo;
                    lightingEventArgs.Sampler.Base.Colour.Value = colour.ColourTwo;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    samplerChanged?.Invoke(this, lightingEventArgs.Sampler);
                    samplerXChanged?.Invoke(this, lightingEventArgs.Sampler.Base);
                    colourChanged?.Invoke(this, lightingEventArgs.Sampler.Base.Colour);
                    OnColourTwoChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourTwo
                    });
                    break;
                
                case "ColourThree":
                    lightingEventArgs.Sampler.Base.Colour.TypeChanged = ThreeColourEnum.ColourThree;
                    lightingEventArgs.Sampler.Base.Colour.Value = colour.ColourThree;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    samplerChanged?.Invoke(this, lightingEventArgs.Sampler);
                    samplerXChanged?.Invoke(this, lightingEventArgs.Sampler.Base);
                    colourChanged?.Invoke(this, lightingEventArgs.Sampler.Base.Colour);
                    OnColourThreeChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourThree
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ThreeColourEvents-HandleSamplerEvents");
            }
        }

        protected internal void HandleEncoderEvents(string serialNumber, ThreeColour colour, MemberInfo memInfo,
            EventHandler<LightingEventArgs> lightningChanged,
            EventHandler<EncoderLightingEventArgs> encoderChanged,
            EventHandler<ThreeColourEventArgs> colorChanged,
            LightingEventArgs lightingEventArgs)
        {
            lightingEventArgs.Encoder.Colour = new ThreeColourEventArgs
            {
                SerialNumber = serialNumber,
            };
            
            switch (memInfo.Name)
            {
                case "ColourOne":
                    lightingEventArgs.Encoder.Colour.TypeChanged = ThreeColourEnum.ColourOne;
                    lightingEventArgs.Encoder.Colour.StringValue = colour.ColourOne;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    encoderChanged?.Invoke(this, lightingEventArgs.Encoder);
                    colorChanged?.Invoke(this, lightingEventArgs.Encoder.Colour);
                    OnColourOneChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourOne
                    });
                    break;
                
                case "ColourTwo":
                    lightingEventArgs.Encoder.Colour.TypeChanged = ThreeColourEnum.ColourTwo;
                    lightingEventArgs.Encoder.Colour.StringValue = colour.ColourTwo;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    encoderChanged?.Invoke(this, lightingEventArgs.Encoder);
                    colorChanged?.Invoke(this, lightingEventArgs.Encoder.Colour);
                    OnColourTwoChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourTwo
                    });
                    break;
                
                case "ColourThree":
                    lightingEventArgs.Encoder.Colour.TypeChanged = ThreeColourEnum.ColourThree;
                    lightingEventArgs.Encoder.Colour.StringValue = colour.ColourThree;

                    lightningChanged?.Invoke(this, lightingEventArgs);
                    encoderChanged?.Invoke(this, lightingEventArgs.Encoder);
                    colorChanged?.Invoke(this, lightingEventArgs.Encoder.Colour);
                    OnColourThreeChanged?.Invoke(this, new StringDeviceEventArgs
                    {
                        SerialNumber = serialNumber,
                        Value = colour.ColourThree
                    });
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in ThreeColourEvents-HandleSamplerEvents");
            }
        }
    }
}