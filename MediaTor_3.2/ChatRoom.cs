namespace MediaTor_3._2
{
    public class ChatRoom : IChatMediaTor
    {
        private readonly List<User> users = [];

        public void AddUser(User user)
        {
            users.Add(user);
            user.SetMediator(this);
        }

        public void Notify(User sender, string @event)
        {
            foreach (var user in users)
            {
                if (user != sender)
                {
                    user.Receive(@event, sender.Name);
                }
            }
        }
    }
}
