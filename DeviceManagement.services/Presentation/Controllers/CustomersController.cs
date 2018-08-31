using System.Linq;
using Application.Exceptions;
using Application.Domain;
using Infrastructure.Command;
using Infrastructure.CQRS.CommandDispatcher;
using Infrastructure.QueryCommand;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;

        public CustomersController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        [HttpPost]
        public void Create(CreateCustomerCommand command)
        {
            if(ModelState.IsValid) 
                _commandDispatcher.RunCommand(command);
            else 
                throw new InvalidCreateCustomerCommadException();
        }

        [HttpPost]
        public string Load(LoadAllCustomersQueryCommand command)
        {
           return _commandDispatcher.RunQuery<LoadAllCustomersQueryCommand, string>(command);
        }
    }
}
