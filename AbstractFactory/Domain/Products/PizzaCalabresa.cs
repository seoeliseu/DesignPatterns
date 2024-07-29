namespace AbstractFactory.Domain.Products
{
    public sealed class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa() : base("Pizza de Calabresa", Enum.TipoMassa.Pizza)
        {
            Igredientes.Add("Calabresa");
            Igredientes.Add("Queijo");
            Igredientes.Add("Tomate");
            Igredientes.Add("Massa de Pizza");
        }
    }
}
