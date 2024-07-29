using AbstractFactory.Domain.Enum;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory.AbstractFactory
{
    public abstract class MassasAbstractFactory
    {
        public abstract MassaBase CriarMassa(TipoMassa tipoMassa);
        public static MassasAbstractFactory CriarFabricaDeMassas(TipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                {
                    return new PizzaFactory();
                }
                case TipoMassa.Bolo:
                {
                    return new BoloFactory();
                }
                default:
                {
                    throw new ApplicationException("Massa não encontrada");
                }
                    
            }
        }
    }
}
