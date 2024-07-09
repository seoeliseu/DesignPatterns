using Builder.Product;

namespace Builder.Builder
{
    public abstract class ArmaBuilder
    {
        protected Arma arma;

        public void CriarArma()
        {
            arma = new Arma();
        }

        public Arma ObterArma()
        {
            return arma;
        }

        public abstract void EscolherTipoArma();
        public abstract void EscolherAcessorios();
        public abstract void EscolherCor();
    }
}
