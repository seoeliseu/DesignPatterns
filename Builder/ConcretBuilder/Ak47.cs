using Builder.Builder;
using Builder.Enum;
using Builder.Product;

namespace Builder.ConcretBuilder
{
    public class Ak47 : ArmaBuilder
    {
        public override ArmaBuilder EscolherAcessorios()
        {
            arma.Acessorios = new List<AcessoriosArmaEnum> { AcessoriosArmaEnum.PenteExtendido, AcessoriosArmaEnum.RedDot };
            return this;
        }
        public override ArmaBuilder EscolherCor()
        {
            arma.Cor = CorArmaEnum.Dourada;
            return this;
        }
        public override ArmaBuilder EscolherTipoArma()
        {
            arma.TipoArma = TipoArmaEnum.RifleAutomatico;
            return this;
        }
    }
}
