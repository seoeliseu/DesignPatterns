namespace Mediator
{
    public abstract class User
    {
        protected IFacebookGroupMediator mediator;
        protected string name;
        public User(IFacebookGroupMediator med, string name)
        {
            mediator = med;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
