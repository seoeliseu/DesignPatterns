namespace Decorator
{
    public class NotificaFirefight : INotificaFirefight
    {
        public void Notificar()
        {
            Console.WriteLine("Notificado via email");
        }
    }
}
