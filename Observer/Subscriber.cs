namespace Observer
{
    public class Subscriber(string nome) : ISubscriber
    {
        public string Nome { get; set; } = nome;

        public void Update(string message)
        {
           Console.WriteLine($"{Nome} recebeu a mensagem: {message}");
        }
    }
}
