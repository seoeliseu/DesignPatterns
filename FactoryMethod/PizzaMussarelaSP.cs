namespace FactoryMethod
{
    // Concrete Product
    public class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de Mussarela SP";
            Massa = "Massa fina";
            Molho = "Molho de tomate";
            Ingredientes.Add("Queijo Mussarela");
            Ingredientes.Add("Tomate");
            Ingredientes.Add("Orégano");
        }
    }
}
