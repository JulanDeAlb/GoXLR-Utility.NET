using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Mixer.Levels;
using GoXLR_Utility.NET.EventArgs.Response.Status.Mixer.Levels;
using GoXLR_Utility.NET.Events.Response.Status.Mixer.Levels.Volumes;
using GoXLR_Utility.NET.Models.Response.Status.Mixer.Levels;

namespace GoXLR_Utility.NET.Events.Response.Status.Mixer.Levels
{
    /// <summary>
    /// <seealso cref="Levels"/>
    /// </summary>
    public class LevelEvents
    {
        public VolumeEvents Volume = new VolumeEvents();

        public event EventHandler<LevelEventArgs> OnLevelChanged;

        public event EventHandler<SpecificLevelEventArgs> OnBleepLevelChanged;

        public event EventHandler<SpecificLevelEventArgs> OnDeEsserLevelChanged;

        protected internal void HandleEvents(string serialNumber, Models.Response.Status.Mixer.Levels.Levels levels, MemberInfo memInfo)
        {
            var levelEventArgs = new LevelEventArgs
            {
                SerialNumber = serialNumber
            };

            var specLevelEventArgs = new SpecificLevelEventArgs
            {
                SerialNumber = serialNumber
            };
            
            switch (memInfo.Name)
            {
                case "Bleep":
                    levelEventArgs.LevelEnum = LevelEnum.Bleep;
                    levelEventArgs.Volume = specLevelEventArgs.Volume = levels.Bleep;
                    OnLevelChanged?.Invoke(this, levelEventArgs);
                    OnBleepLevelChanged?.Invoke(this, specLevelEventArgs);
                    break;
                
                case "DeEsser":
                    levelEventArgs.LevelEnum = LevelEnum.DeEsser;
                    levelEventArgs.Volume = specLevelEventArgs.Volume = levels.DeEsser;
                    OnLevelChanged?.Invoke(this, levelEventArgs);
                    OnDeEsserLevelChanged?.Invoke(this, specLevelEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in LevelEvents");
            }
        }
    }
}