namespace Mediator
{
    //ConcreteMediator
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> userList = new List<User>();
        public void RegisterUser(User user)
        {
            userList.Add(user);
        }
        public void SendMessage(string message, User user)
        {
            foreach (var u in userList)
            {
                //message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
