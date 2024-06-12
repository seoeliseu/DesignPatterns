namespace Observer
{
    public class Publicador
    {
        private readonly List<ISubscriber> Subscribers;

        public Publicador()
        {
            Subscribers = [];
        }

        public void Subscribe(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void Notify(string message)
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.Update(message);
            }
        }

    }
}
