namespace Infrastructure.CQRS.CommandHandler
{
    public interface IDomainCommandHandler<TCommand> : ICommand
    {
        void Run(TCommand command);
    }
}