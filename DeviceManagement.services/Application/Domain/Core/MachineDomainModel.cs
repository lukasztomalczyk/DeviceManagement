using Application.Domain.Aggregates;
using Infrastructure.Event;
using Infrastructure.Event.ContractsEvent;

namespace Application.Domain.Core
{
    public class MachineDomainModel : AggregateRoot, IHandleEvents<MachineModelCreateEvent>
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public MachineDomainModel(string id)
        {
            Id = id;
        }

        public void Handle(MachineModelCreateEvent @event)
        {
            Name = @event.Name;
            Description = @event.Description;
        }
    }
}