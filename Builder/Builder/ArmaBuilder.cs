using Builder.Product;

namespace Builder.Builder
{
    public abstract class ArmaBuilder
    {
        protected Arma arma;

        public ArmaBuilder CriarArma()
        {
            arma = new Arma();
            return this;
        }

        public Arma ObterArma()
        {
            return arma;
        }

        public abstract ArmaBuilder EscolherTipoArma();
        public abstract ArmaBuilder EscolherAcessorios();
        public abstract ArmaBuilder EscolherCor();
    }
}
