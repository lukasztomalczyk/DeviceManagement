using Infrastructure.Command;
using Infrastructure.CQRS.CommandHandler;

namespace Application.Domain.CommandHandler
{
    public class CreateCustomerCommandHandler : IDomainCommandHandler<CreateCustomerCommand>
    {
        public void Run(CreateCustomerCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}