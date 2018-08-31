using System;
using System.Collections.Generic;
using Infrastructure.Event;

namespace Application.Domain.Aggregates
{
    public abstract class AggregateRoot : IAggregateRoot
    {
        public Guid Id { get; protected set; }
        public int Version { get; protected set; } = -1;
        
        protected List<IEvent> Events { get; set; } = new List<IEvent>();
        
        public virtual List<IEvent> GetUncommittedEvents()
        {
            return Events;
        }

        public virtual void MarkEventsAsCommitted()
        {
            Events.Clear();
        }

        public virtual void LoadFromHistory(IEnumerable<IEvent> events)
        {
            foreach (var item in events)
            {
                ApplyChange(item, false);
            }
        }
        
        protected void ApplyChange(IEvent @event, bool isNew = true)
        {
            var handleType = typeof(IHandleEvents<>).MakeGenericType(@event.GetType());

            var eventType = @event.GetType();

            handleType.GetMethod(nameof(IHandleEvents<IEvent>.Handle), new[] { eventType })
                .Invoke(this, new object[] { @event });

            if(isNew) Events.Add(@event);
        }
        
    }
}