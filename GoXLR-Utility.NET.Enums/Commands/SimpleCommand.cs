namespace GoXLR_Utility.NET.Enums.Commands
{
    public enum SimpleCommand
    {
        /// <summary>
        /// The HttpState are all http related settings of Daemon Utility.<br/>
        /// It will automatically parsed into the HttpStatus.
        /// </summary>
        GetHttpState,

        /// <summary>
        /// The HttpState are all the Settings of the Utility (including the Device).<br/>
        /// It will automatically parsed into the Status.
        /// </summary>
        GetStatus,

        OpenUi,
        Ping,
        StopDaemon
    }
}