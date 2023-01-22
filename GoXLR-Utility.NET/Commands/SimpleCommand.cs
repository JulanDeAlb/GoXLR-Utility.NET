using GoXLR_Utility.NET.Enums.Commands;

namespace GoXLR_Utility.NET.Commands
{
    public class SimpleCommand : CommandBase
    {
        public SimpleCommand(SimpleCommandEnum command)
        {
            Object = command;
        }
    }
}