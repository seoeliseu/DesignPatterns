namespace FactoryMethod
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaFactory(string cidade)
        {
            if (cidade.Equals("SP"))
            {
                return new PizzaFactorySP();
            }
            else if (cidade.Equals("RJ"))
            {
                return new PizzaFactoryRJ();
            }
            else return null;
        }
    }
}
