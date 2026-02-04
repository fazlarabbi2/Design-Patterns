namespace MediaTor;

public class ConcreteMediator : Mediator
{
    private readonly Colleague1 colleague1;
    private readonly Colleague2 colleague2;
    
    public ConcreteMediator(Colleague1 colleague1, Colleague2 colleague2)
    {
        this.colleague1 = colleague1;
        this.colleague1.SetMediator(this);
        this.colleague2 = colleague2;
        this.colleague2.SetMediator(this);
    }

    public void Notify(Colleague sender, string @event)
    {
        Console.WriteLine($"Concrete mediator notified by {sender.GetType().Name}");

        if (sender == colleague1)
        {
            // Call some method on colleague 2
            this.colleague2.Receive(@event);
        }
        if (sender == colleague2)
        {
            // Call some method on colleague 1
            this.colleague1.Receive(@event);
        }
    }
}