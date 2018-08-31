using System;
using System.Collections.Generic;

namespace Infrastructure.Event
{
    public interface IAggregateRoot
    {
        Guid Id { get; }

        int Version { get; }

        List<IEvent> GetUncommittedEvents();

        void MarkEventsAsCommitted();

        void LoadFromHistory(IEnumerable<IEvent> events);
    }
}