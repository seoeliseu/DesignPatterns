using Builder.Builder;
using Builder.Product;

namespace Builder.Director
{
    public class IndustriaBelica
    {
        private readonly ArmaBuilder _armaBuilder;

        public IndustriaBelica(ArmaBuilder armaBuilder)
        {
            _armaBuilder = armaBuilder;
        }

        public void MontarArma()
        {
            _armaBuilder.CriarArma().EscolherTipoArma().EscolherAcessorios().EscolherCor();
        }
        public Arma ObterArma()
        {
            return _armaBuilder.ObterArma();
        }
    }
}
