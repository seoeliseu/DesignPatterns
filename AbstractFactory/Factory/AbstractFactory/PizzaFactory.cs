using AbstractFactory.Domain.Enum;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory.AbstractFactory
{
    public sealed class PizzaFactory : MassasAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;

            switch (tipoPizza)
            {
                case TipoPizza.Calabresa:
                {
                    return new PizzaCalabresa();
                }
                case TipoPizza.Mussarela:
                {
                    return new PizzaMussarela();
                }
                default:
                    {
                    throw new ApplicationException("Pizza não encontrada");
                }
            }
        }
    }
}
