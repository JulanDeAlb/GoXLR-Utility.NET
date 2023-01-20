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
        public event EventHandler<StringPathEventArgs> OnIconsDirectoryChanged;
        public event EventHandler<StringPathEventArgs> OnMicProfileDirectoryChanged;
        public event EventHandler<StringPathEventArgs> OnPresetsDirectoryChanged;
        public event EventHandler<StringPathEventArgs> OnProfileDirectoryChanged;
        public event EventHandler<StringPathEventArgs> OnSamplesDirectoryChanged;

        protected internal void HandleEvents(Models.Response.Status.Paths.Paths paths, MemberInfo memInfo)
        {
            var pathEventArgs = new PathEventArgs();
            var specPathEventArgs = new StringPathEventArgs();
            
            switch (memInfo.Name)
            {
                case "IconsDirectory":
                    pathEventArgs.TypeChanged = PathEnum.IconsDirectory;
                    pathEventArgs.Value = specPathEventArgs.Value = paths.IconsDirectory;
                    OnPathsChanged?.Invoke(this, pathEventArgs);
                    OnIconsDirectoryChanged?.Invoke(this, specPathEventArgs);
                    break;
                
                case "MicProfileDirectory":
                    pathEventArgs.TypeChanged = PathEnum.MicProfileDirectory;
                    pathEventArgs.Value = specPathEventArgs.Value = paths.MicProfileDirectory;
                    OnPathsChanged?.Invoke(this, pathEventArgs);
                    OnMicProfileDirectoryChanged?.Invoke(this, specPathEventArgs);
                    break;
                
                case "PresetsDirectory":
                    pathEventArgs.TypeChanged = PathEnum.PresetsDirectory;
                    pathEventArgs.Value = specPathEventArgs.Value = paths.PresetsDirectory;
                    OnPathsChanged?.Invoke(this, pathEventArgs);
                    OnPresetsDirectoryChanged?.Invoke(this, specPathEventArgs);
                    break;
                
                case "ProfileDirectory":
                    pathEventArgs.TypeChanged = PathEnum.ProfileDirectory;
                    pathEventArgs.Value = specPathEventArgs.Value = paths.ProfileDirectory;
                    OnPathsChanged?.Invoke(this, pathEventArgs);
                    OnProfileDirectoryChanged?.Invoke(this, specPathEventArgs);
                    break;
                
                case "SamplesDirectory":
                    pathEventArgs.TypeChanged = PathEnum.SamplesDirectory;
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