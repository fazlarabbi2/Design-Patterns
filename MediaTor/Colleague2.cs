namespace MediaTor;

public class Colleague2 : Colleague
{
    public void Operation2()
    {
        Console.WriteLine("Colleague 2 does operation 2");
        _mediator.Notify(this, "Colleague 2 did operation 2");
    }

    public void Receive(string @event)
    {
        Console.WriteLine($"Colleague 2 received: {@event}");
    }
}