namespace Decorator
{
    public class NotificaFirefightDecorator(INotificaFirefight notificaFirefight) : INotificaFirefight
    {
        private readonly INotificaFirefight _notificaFirefight = notificaFirefight;

        public void Notificar()
        {
            _notificaFirefight.Notificar();
        }
    }
}
