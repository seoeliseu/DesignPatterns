namespace FactoryMethod
{
    public class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP()
        {
            Nome = "Pizza de Calabresa SP";
            Massa = "Massa fina";
            Molho = "Molho de tomate";
            Ingredientes.Add("Queijo Mussarela");
            Ingredientes.Add("Calabresa");
            Ingredientes.Add("Cebola");
            Ingredientes.Add("Orégano");
        }
    }
}
