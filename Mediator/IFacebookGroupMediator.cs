namespace Mediator
{
    //Mediator
    public interface IFacebookGroupMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }
}
 