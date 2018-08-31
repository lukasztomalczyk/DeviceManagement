using System;

namespace Infrastructure.Event.ContractsEvent
{
    public class MachineModelCreateEvent : IEvent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        
        public Guid AggregateId { get; }
        public DateTime CreateDate { get; }
    }
}