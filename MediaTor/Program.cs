namespace MediaTor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colleague1 colleague1 = new();
            Colleague2 colleague2 = new();


            ConcreteMediator mediator = new(colleague1, colleague2);
            
            colleague1.Operation1();
            colleague2.Operation2();
        }
    }
}
