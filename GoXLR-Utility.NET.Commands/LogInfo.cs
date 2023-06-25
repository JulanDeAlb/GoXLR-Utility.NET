using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET.Commands
{
    public class LogInfo
    {
        public LogLevel LogLevel { get; private set; }
        public EventId EventId { get; private set; }
        public bool IsMinimum { get; private set; }
        public string CmdName { get; private set; }
        public string Value { get; private set; }
        
        public LogInfo(LogLevel logLevel, EventId eventId, bool isMinimum, string cmdName, string value)
        {
            LogLevel = logLevel;
            EventId = eventId;
            IsMinimum = isMinimum;
            CmdName = cmdName;
            Value = value;
        }
    }
}