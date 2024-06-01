namespace Composite
{
    public class ArquivoPDF(string nome) : IComponent
    {
        public string Nome { get; set; } = nome;
        public void Criptografar()
        {
            Console.WriteLine($"Arquivo PDF criptografado: {Nome}");
        }
    }
}
