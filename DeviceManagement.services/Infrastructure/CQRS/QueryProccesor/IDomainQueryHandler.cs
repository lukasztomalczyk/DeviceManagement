namespace Infrastructure.CQRS.QueryProccesor
{
    public interface IDomainQueryHandler<TCommand, TOut> : ICommand
    {
        TOut Handle(TCommand command);
    }
}