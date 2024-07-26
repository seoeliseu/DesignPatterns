namespace FactoryMethod
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("CALABRESA"))
            {
                return new PizzaCalabresaSP();
            }
            else if (tipo.Equals("MUSSARELA"))
            {
                return new PizzaMussarelaSP();
            }
            else return null;
        }
    }
}
