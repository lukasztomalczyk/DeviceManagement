using Infrastructure.CQRS.QueryProccesor;
using Infrastructure.QueryCommand;

namespace Application.Domain.QueryHandler
{
    public class LoadAllCustomerQueryHandler: IDomainQueryHandler<LoadAllCustomersQueryCommand, string>
    {
        public string Handle(LoadAllCustomersQueryCommand command)
        {
            return "ok poszlo";
        }
    }
}