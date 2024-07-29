using AbstractFactory.Domain.Enum;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory.AbstractFactory
{
    public sealed class BoloFactory : MassasAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipo)
        {
            var tipoBolo = (TipoBolo)tipo;

            switch (tipoBolo)
            {
                case TipoBolo.Chocolate:
                    return new BoloChocoloate();
                case TipoBolo.Morango:
                    return new BoloLaranja();
                default:
                    throw new ApplicationException("Bolo não encontrado");
            }
        }
    }
}
