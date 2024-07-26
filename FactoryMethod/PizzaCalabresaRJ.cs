namespace FactoryMethod
{
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            Nome = "Pizza de Calabresa RJ";
            Massa = "Massa fina";
            Molho = "Molho de tomate";
            Ingredientes.Add("Calabresa");
            Ingredientes.Add("Cebola");
            Ingredientes.Add("Orégano");
        }
    }
}
