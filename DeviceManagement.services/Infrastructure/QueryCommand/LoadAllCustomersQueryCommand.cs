using Infrastructure.CQRS;

namespace Infrastructure.QueryCommand
{
    public class LoadAllCustomersQueryCommand : ICommand
    {
        private string Command { get; }

        public LoadAllCustomersQueryCommand(string command)
        {
            Command = command;
        }
    }
}