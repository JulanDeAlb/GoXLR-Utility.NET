using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Paths;
using GoXLR_Utility.NET.Models.Response.Status.Paths;
using GoXLR_Utility.NET.EventArgs.Response.Status.Paths;

namespace GoXLR_Utility.NET.Events.Response.Status.Paths
{
    /// <summary>
    /// <seealso cref="Paths"/>
    /// </summary>
    public class PathEvents
    {
        public event EventHandler<PathEventArgs> OnPathsChanged;
        public event EventHandler<SpecificPathEventArgs> OnIconsDirectoryChanged;
        public event EventHandler<SpecificPathEventArgs> OnMicProfileDirectoryChanged;
        public event EventHandler<SpecificPathEventArgs> OnPresetsDirectoryChanged;
        public event EventHandler<SpecificPathEventArgs> OnProfileDirectoryChanged;
        public event EventHandler<SpecificPathEventArgs> OnSamplesDirectoryChanged;

        protected internal void HandleEvents(Models.Response.Status.Paths.Paths paths, MemberInfo memInfo)
        {
            var pathEventArgs = new PathEventArgs();
            var specPathEventArgs = new SpecificPathEventArgs();
            
            switch (memInfo.Name)
            {
                case "IconsDirectory":
                    pathEventArgs.PathEnum = PathEnum.IconsDirectory;
                    pathEventArgs.Value = specPathEventArgs.Value = paths.IconsDirectory;
                    OnPathsChanged?.Invoke(this, pathEventArgs);
                    OnIconsDirectoryChanged?.Invoke(this, specPathEventArgs);
                    break;
                
                case "MicProfileDirectory":
                    pathEventArgs.PathEnum = PathEnum.MicProfileDirectory;
                    pathEventArgs.Value = specPathEventArgs.Value = paths.MicProfileDirectory;
                    OnPathsChanged?.Invoke(this, pathEventArgs);
                    OnMicProfileDirectoryChanged?.Invoke(this, specPathEventArgs);
                    break;
                
                case "PresetsDirectory":
                    pathEventArgs.PathEnum = PathEnum.PresetsDirectory;
                    pathEventArgs.Value = specPathEventArgs.Value = paths.PresetsDirectory;
                    OnPathsChanged?.Invoke(this, pathEventArgs);
                    OnPresetsDirectoryChanged?.Invoke(this, specPathEventArgs);
                    break;
                
                case "ProfileDirectory":
                    pathEventArgs.PathEnum = PathEnum.ProfileDirectory;
                    pathEventArgs.Value = specPathEventArgs.Value = paths.ProfileDirectory;
                    OnPathsChanged?.Invoke(this, pathEventArgs);
                    OnProfileDirectoryChanged?.Invoke(this, specPathEventArgs);
                    break;
                
                case "SamplesDirectory":
                    pathEventArgs.PathEnum = PathEnum.SamplesDirectory;
                    pathEventArgs.Value = specPathEventArgs.Value = paths.SamplesDirectory;
                    OnPathsChanged?.Invoke(this, pathEventArgs);
                    OnSamplesDirectoryChanged?.Invoke(this, specPathEventArgs);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException($"The Property Name ({memInfo.Name}) is not implemented in PathEvents");
            }
        }
    }
}