namespace GoXLR_Utility.NET.Commands.Mixer.Sampler
{
    public class ClearSampleProcessError : DeviceCommandBase
    {
        /// <summary>
        /// Clear the sample process error.
        /// </summary>
        public ClearSampleProcessError()
        {
            Object = "SetSamplerPreBufferDuration";
        }
    }
}