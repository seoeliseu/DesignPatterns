using Decorator;

var notificaFirefighter = new NotificaFirefight();

notificaFirefighter.Notificar();

Console.WriteLine("------------------------------------------------------------------");

var notificaFirefighterGerente = new NotificaFirefightGerente(notificaFirefighter);

notificaFirefighterGerente.Notificar();

Console.ReadKey();