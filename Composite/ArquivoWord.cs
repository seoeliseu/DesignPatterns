namespace Composite
{
    public class ArquivoWord(string nome) : IComponent
    {
        public string Nome { get; set; } = nome;
        public void Criptografar()
        {
            Console.WriteLine($"Arquivo Word criptografado: {Nome}");
        }
    }
}
