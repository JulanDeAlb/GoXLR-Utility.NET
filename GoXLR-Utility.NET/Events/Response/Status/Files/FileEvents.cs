using System;
using System.Reflection;
using GoXLR_Utility.NET.Enums.Response.Status.Files;
using GoXLR_Utility.NET.EventArgs.Response.Status.Files;
using GoXLR_Utility.NET.Models.Patch;
using GoXLR_Utility.NET.Models.Response.Status.Files;

namespace GoXLR_Utility.NET.Events.Response.Status.Files
{
    /// <summary>
    /// <seealso cref="Files"/>
    /// </summary>
    public class FileEvents
    {
        public event EventHandler<FileEventArgs> OnFilesChanged;
        public event EventHandler<ListFileEventArgs> OnIconsChanged;
        public event EventHandler<ListFileEventArgs> OnMicProfilesChanged;
        public event EventHandler<ListFileEventArgs> OnPresetsChanged;
        public event EventHandler<ListFileEventArgs> OnProfilesChanged;
        public event EventHandler<DictionaryFileEventArgs> OnSamplesChanged;

        protected internal void HandleEvents(Models.Response.Status.Files.Files files,
            MemberInfo memInfo, OpPatchEnum patchOp, object value)

        {
            var fileEventArgs = new FileEventArgs
            {
                PatchType = patchOp,
            };

            var listFileEventArgs = new ListFileEventArgs
            {
                PatchType = patchOp
            };

            if (memInfo.Name != "Samples")
                listFileEventArgs.Item = (string)value;

            switch (memInfo.Name)
            {
                case "Icons":
                    fileEventArgs.FileEnum = FileEnum.Icons;
                    fileEventArgs.List = listFileEventArgs.List = files.Icons;
                    OnFilesChanged?.Invoke(this, fileEventArgs);
                    OnIconsChanged?.Invoke(this, listFileEventArgs);
                    break;

                case "MicProfiles":
                    fileEventArgs.FileEnum = FileEnum.MicProfiles;
                    fileEventArgs.List = listFileEventArgs.List = files.MicProfiles;
                    OnFilesChanged?.Invoke(this, fileEventArgs);
                    OnMicProfilesChanged?.Invoke(this, listFileEventArgs);
                    break;

                case "Presets":
                    fileEventArgs.FileEnum = FileEnum.Presets;
                    fileEventArgs.List = listFileEventArgs.List = files.Presets;
                    OnFilesChanged?.Invoke(this, fileEventArgs);
                    OnPresetsChanged?.Invoke(this, listFileEventArgs);
                    break;

                case "Profiles":
                    fileEventArgs.FileEnum = FileEnum.Profiles;
                    fileEventArgs.List = listFileEventArgs.List = files.Profiles;
                    OnFilesChanged?.Invoke(this, fileEventArgs);
                    OnProfilesChanged?.Invoke(this, listFileEventArgs);
                    break;

                case "Samples":
                    var dictionaryFileEventArgs = new DictionaryFileEventArgs
                    {
                        PatchType = patchOp
                    };
                    fileEventArgs.FileEnum = FileEnum.Samples;
                    fileEventArgs.Dictionary = dictionaryFileEventArgs.Dictionary = files.Samples;
                    OnFilesChanged?.Invoke(this, fileEventArgs);
                    OnSamplesChanged?.Invoke(this, dictionaryFileEventArgs);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        $"The Property Name ({memInfo.Name}) is not implemented in FileEvents");
            }
        }
    }
}