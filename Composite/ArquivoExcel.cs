namespace Composite
{
    public class ArquivoExcel(string nome) : IComponent
    {
        public string Nome { get; set; } = nome;
        public void Criptografar()
        {
            Console.WriteLine($"Arquivo Excel criptografado: {Nome}");
        }
    }
}
