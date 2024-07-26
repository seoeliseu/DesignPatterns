namespace FactoryMethod
{
    // Concrete Creator
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("calabresa"))
            {
                return new PizzaCalabresaRJ();
            }
            else if (tipo.Equals("mussarela"))
            {
                return new PizzaMussarelaRJ();
            }
            else return null;
        }
    }
}
