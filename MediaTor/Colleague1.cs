namespace MediaTor;

public class Colleague1 : Colleague
{
    public void Operation1()
    {
        Console.WriteLine("Colleague 1 does operation 1");
        _mediator.Notify(this, "Colleague 1 did operation 1");
    }

    public void Receive(string @event)
    {
        Console.WriteLine($"Colleague 2 received: {@event}");
    }
}