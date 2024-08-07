using Mediator;

IFacebookGroupMediator mediator = new ConcreteFacebookGroupMediator();

User u1 = new ConcreteUser(mediator, "User1");
User u2 = new ConcreteUser(mediator, "User2");
User u3 = new ConcreteUser(mediator, "User3");
User u4 = new ConcreteUser(mediator, "User4");

mediator.RegisterUser(u1);
mediator.RegisterUser(u2);
mediator.RegisterUser(u3);
mediator.RegisterUser(u4);

u1.Send("Ola ! user 2");

u2.Send("Ola user 1 tudo bem ?");

u1.Send("tudo bem user 2 e voce como esta ?");

Console.Read();