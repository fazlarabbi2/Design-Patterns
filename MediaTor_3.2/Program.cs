namespace MediaTor_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChatRoom chatRoom = new();
            RegularUser alice = new RegularUser("Alice");
            AdminUser bob = new AdminUser("Bob");

            AdminUser charlie = new AdminUser("Charlie");

            chatRoom.AddUser(alice);
            chatRoom.AddUser(bob);
            chatRoom.AddUser(charlie);

            charlie.Send("Welcome, Everybody!");
            alice.Send("Hello, everyone!");
            bob.Send("Hi Alice!, How are you?");
            alice.Send("I'm good, thanks Bob!");

            charlie.BroadcastAlert("Keep it friendly guys!");
        }
    }
}
