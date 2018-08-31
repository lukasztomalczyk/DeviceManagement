using System;
using Infrastructure.CQRS.CommandHandler;
using Infrastructure.CQRS.QueryProccesor;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.CQRS.CommandDispatcher
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void RunCommand<TCommand>(TCommand command)
        {
            var handler = _serviceProvider.GetService<IDomainCommandHandler<TCommand>>();
            
            handler.Run(command);
        }

        public TOut RunQuery<TCommand, TOut>(TCommand command)
        {
            var handler = _serviceProvider.GetService<IDomainQueryHandler<TCommand, TOut>>();

            return handler.Handle(command);
        }
    }
}