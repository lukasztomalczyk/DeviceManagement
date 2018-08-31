using System;

namespace Infrastructure.Event
{
    public interface IEvent
    {
        Guid AggregateId { get; }
        DateTime CreateDate { get; }
    }
}