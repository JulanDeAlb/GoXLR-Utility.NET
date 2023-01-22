using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Common;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Settings.Display;
using GoXLR_Utility.NET.Models.Response.Status;

namespace GoXLR_Utility.NET.Tests
{
    public class JsonDeserializeTest
    {
        private readonly string _statusString;
        private readonly JsonSerializerOptions _serializerOptions = new()
        {
            Converters = { new JsonStringEnumConverter() },
            WriteIndented = true
        };
        
        public JsonDeserializeTest()
        {
            const string resourceName = "GoXLR_Utility.NET.Tests.EmbeddedResources.Status.json";
            var assembly = Assembly.GetExecutingAssembly();

            using var stream = assembly.GetManifestResourceStream(resourceName);
            using var reader = new StreamReader(stream!);
            _statusString = reader.ReadToEnd();
        }

        [Fact]
        public void DeserializeStatus()
        {
            Status? status = null;
            var exception = Record.Exception(() =>
            {
                status = JsonSerializer.Deserialize<Status>(_statusString, _serializerOptions);
            });

            Assert.Null(exception);
            
            Assert.NotNull(status);

            #region Status.Config

            Assert.NotNull(status.Config);
            Assert.True(status.Config.AutostartEnabled);
            Assert.Equal("0.9.0", status.Config.DaemonVersion);
            Assert.True(status.Config.ShowTrayIcon);

            #endregion

            #region Status.Files

            Assert.NotNull(status.Files);
            Assert.Equal("headphone.png", status.Files.Icons[0]);
            Assert.Equal("DEFAULT", status.Files.MicProfiles[0]);
            Assert.Equal("BadMic", status.Files.Presets[0]);
            Assert.Equal("Main", status.Files.Profiles[0]);
            Assert.Equal("123.wav", status.Files.Samples["Recorded\\123.wav"]);

            #endregion

            #region Status.Mixer

            Assert.NotNull(status.Mixers);
            Assert.NotNull(status.Mixers["SerialNumber"]);

            #region Status.Mixer.ButtonDown

            Assert.NotNull(status.Mixers["SerialNumber"].ButtonDown);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.Bleep);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.Cough);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectFx);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectHardTune);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectMegaphone);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectRobot);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect1);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect2);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect3);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect4);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect5);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.EffectSelect6);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.Fader1Mute);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.Fader2Mute);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.Fader3Mute);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.Fader4Mute);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerClear);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerSelectA);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerSelectB);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerSelectC);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerBottomLeft);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerBottomRight);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerTopLeft);
            Assert.True(status.Mixers["SerialNumber"].ButtonDown.SamplerTopRight);

            #endregion

            #region Status.Mixer.CoughButton

            Assert.NotNull(status.Mixers["SerialNumber"].CoughButton);
            Assert.True(status.Mixers["SerialNumber"].CoughButton.IsToggle);
            Assert.Equal(MuteFunction.All, status.Mixers["SerialNumber"].CoughButton.MuteFunction);
            Assert.Equal(MuteState.Unmuted, status.Mixers["SerialNumber"].CoughButton.MuteState);

            #endregion
            
            Assert.NotNull(status.Mixers["SerialNumber"].Effects);
            
            Assert.NotNull(status.Mixers["SerialNumber"].FaderStatus);
            
            Assert.NotNull(status.Mixers["SerialNumber"].Hardware);
            
            Assert.NotNull(status.Mixers["SerialNumber"].Levels);
            
            Assert.NotNull(status.Mixers["SerialNumber"].Lighting);
            
            Assert.Equal("DEFAULT", status.Mixers["SerialNumber"].MicProfileName);
            
            Assert.NotNull(status.Mixers["SerialNumber"].MicStatus);
            
            Assert.Equal("Main", status.Mixers["SerialNumber"].ProfileName);
            
            Assert.NotNull(status.Mixers["SerialNumber"].Router);
            
            Assert.NotNull(status.Mixers["SerialNumber"].Sampler);

            #region Status.Mixer.Settings

            Assert.NotNull(status.Mixers["SerialNumber"].Settings);

            #region Status.Mixer.Settings.Display

            Assert.NotNull(status.Mixers["SerialNumber"].Settings.Display);
            Assert.Equal(DisplayModeEnum.Advanced, status.Mixers["SerialNumber"].Settings.Display.Compressor);
            Assert.Equal(DisplayModeEnum.Advanced, status.Mixers["SerialNumber"].Settings.Display.Gate);
            Assert.Equal(DisplayModeEnum.Advanced, status.Mixers["SerialNumber"].Settings.Display.Equaliser);
            Assert.Equal(DisplayModeEnum.Simple, status.Mixers["SerialNumber"].Settings.Display.EqualiserFine);

            #endregion

            Assert.Equal(500, status.Mixers["SerialNumber"].Settings.MuteHoldDuration);
            Assert.True(status.Mixers["SerialNumber"].Settings.VcMuteAlsoMuteCm);
            #endregion

            #endregion

            #region Status.Paths

            Assert.NotNull(status.Paths);
            Assert.Equal("C:\\Users\\icons", status.Paths.IconsDirectory);
            Assert.Equal("C:\\Users\\mic-profiles", status.Paths.MicProfileDirectory);
            Assert.Equal("C:\\Users\\presets", status.Paths.PresetsDirectory);
            Assert.Equal("C:\\Users\\profiles", status.Paths.ProfileDirectory);
            Assert.Equal("C:\\Users\\samples", status.Paths.SamplesDirectory);

            #endregion
        }
    }
}