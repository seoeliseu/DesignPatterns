namespace Observer
{
    public class SubscriberGerente : ISubscriber
    {
        public void Update(string message)
        {
            Console.WriteLine($"Gerente recebeu a mensagem: {message}");
            Console.WriteLine($"Autenticar documento");
            Console.WriteLine("Notificar alta gestão");
        }
    }
}
