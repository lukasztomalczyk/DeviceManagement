namespace Infrastructure.Event
{
    public interface IHandleEvents<in TEvent> where TEvent : class, IEvent
    {
        void Handle(TEvent @event);
    }
}