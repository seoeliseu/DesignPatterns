using Builder.Enum;

namespace Builder.Product
{
    public class Arma
    {
        public TipoArmaEnum TipoArma { get; set; }
        public List<AcessoriosArmaEnum> Acessorios { get; set; }
        public CorArmaEnum Cor { get; set; }

        public void ArmaMontada()
        {
            Console.WriteLine($"Arma: {TipoArma}");

            Console.WriteLine($"Acessórios: {Cor}");

            Console.WriteLine($"Cor: {Cor}");

            var acessorios = string.Join(", ", Acessorios);

            Console.WriteLine($"Acessório: {acessorios}");

            Console.WriteLine("\n\n");
        }
    }
}
