﻿namespace Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IFacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{name} received the message: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{name} sends the message: {message}");
            mediator.SendMessage(message, this);
        }
    }
}
