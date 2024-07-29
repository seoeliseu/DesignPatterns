namespace AbstractFactory.Domain.Products
{
    public sealed class BoloChocoloate : Bolo
    {
        public BoloChocoloate() : base("Bolo de Chocolate", Enum.TipoMassa.Bolo)
        {
            Igredientes.Add("Chocolate");
            Igredientes.Add("Farinha");
            Igredientes.Add("Ovos");
            Igredientes.Add("Leite");
            Igredientes.Add("Fermento");
        }
    }
}
