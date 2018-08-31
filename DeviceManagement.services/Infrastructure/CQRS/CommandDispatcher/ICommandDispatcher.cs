namespace Infrastructure.CQRS.CommandDispatcher
{
    public interface ICommandDispatcher
    {
        void RunCommand<TCommand>(TCommand command);
        TOut RunQuery<TCommand, TOut>(TCommand command);
    }
}