using Builder.Builder;
using Builder.Enum;
using Builder.Product;

namespace Builder.ConcretBuilder
{
    public class Ak47 : ArmaBuilder
    {
        public override void EscolherAcessorios()
        {
            arma.Acessorios = new List<AcessoriosArmaEnum> { AcessoriosArmaEnum.PenteExtendido, AcessoriosArmaEnum.RedDot };
        }
        public override void EscolherCor()
        {
            arma.Cor = CorArmaEnum.Dourada;
        }
        public override void EscolherTipoArma()
        {
            arma.TipoArma = TipoArmaEnum.RifleAutomatico;
        }
    }
}
