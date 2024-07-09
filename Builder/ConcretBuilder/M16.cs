using Builder.Builder;
using Builder.Enum;
using Builder.Product;

namespace Builder.ConcretBuilder
{
    public class M16 : ArmaBuilder
    {
        public override void EscolherAcessorios()
        {
            arma.Acessorios = new List<AcessoriosArmaEnum> { AcessoriosArmaEnum.Supressor, AcessoriosArmaEnum.Lanterna };
        }
        public override void EscolherCor()
        {
            arma.Cor = CorArmaEnum.Camuflada;
        }
        public override void EscolherTipoArma()
        {
            arma.TipoArma = TipoArmaEnum.FuzilDeAssalto;
        }
    }
}
