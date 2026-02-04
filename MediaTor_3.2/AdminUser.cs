namespace MediaTor_3._2
{
    public class AdminUser(string name) : User(name)
    {
        private readonly List<User> users = [];
        public override void Receive(string message, string senderName)
        {
            Console.WriteLine($"Admin {Name} receives from {senderName}: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"Admin {Name} announces: {message}");
            mediator.Notify(this, $"Admin Message: {message}");
        }

        internal void BroadcastAlert(string alert)
        {
            Console.WriteLine($"Admin {Name} broadcasts: {alert}");
            mediator.Notify(this, $"ALERT: {alert}");
        }
    }
}
