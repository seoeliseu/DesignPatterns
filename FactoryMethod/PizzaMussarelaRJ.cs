namespace FactoryMethod
{
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de Mussarela RJ";
            Massa = "Massa fina";
            Molho = "Molho de tomate";
            Ingredientes.Add("Queijo Mussarela");
            Ingredientes.Add("Tomate");
        }
    }
}
