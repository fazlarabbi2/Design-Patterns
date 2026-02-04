namespace MediaTor
{
    public interface Mediator
    {
        void Notify(Colleague sender, string @event);
    }
}
