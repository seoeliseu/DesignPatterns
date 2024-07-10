using Builder.Builder;
using Builder.Enum;
using Builder.Product;

namespace Builder.ConcretBuilder
{
    public class M16 : ArmaBuilder
    {
        public override ArmaBuilder EscolherAcessorios()
        {
            arma.Acessorios = new List<AcessoriosArmaEnum> { AcessoriosArmaEnum.Supressor, AcessoriosArmaEnum.Lanterna };
            return this;
        }
        public override ArmaBuilder EscolherCor()
        {
            arma.Cor = CorArmaEnum.Camuflada;
            return this;
        }
        public override ArmaBuilder EscolherTipoArma()
        {
            arma.TipoArma = TipoArmaEnum.FuzilDeAssalto;
            return this;
        }
    }
}
