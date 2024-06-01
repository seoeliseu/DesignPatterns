namespace Decorator
{
    public class NotificaFirefightGerente(INotificaFirefight notificaFirefight) : NotificaFirefightDecorator(notificaFirefight)
    {
        public void NotificarViaWhatsApp()
        {
            Console.WriteLine("Notificado via WhatsApp");
        }

        public new void Notificar()
        {
            base.Notificar();
            NotificarViaWhatsApp();
        }

    }
}
