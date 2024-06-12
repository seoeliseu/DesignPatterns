using Observer;

var publicador = new Publicador();

var subscriber2 = new Subscriber("Kaio");
var subscriber1 = new Subscriber("Eliseu");
var subscriber3 = new SubscriberGerente();

publicador.Subscribe(subscriber1);  
publicador.Subscribe(subscriber2);

publicador.Notify("Olá, mundo!");

publicador.Unsubscribe(subscriber1);
publicador.Subscribe(subscriber3);

Console.WriteLine("--------------------------------------------");

publicador.Notify("Olá, mundo de novo!");

