namespace Composite
{
    public class ArquivoXML(string nome) : IComponent
    {
        public string Nome { get; set; } = nome;
        public void Criptografar()
        {
            Console.WriteLine($"Arquivo XML criptografado: {Nome}");
        }
    }
}
