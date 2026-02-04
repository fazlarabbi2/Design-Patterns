namespace MediaTor_3._2
{
    public abstract class User(string name)
    {
        public string Name { get; protected set; } = name;
        protected IChatMediaTor mediator = null!;

        public void SetMediator(IChatMediaTor mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message, string senderName);
    }
}
