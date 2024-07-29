namespace AbstractFactory.Domain.Products
{
    public sealed class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", Enum.TipoMassa.Bolo)
        {
            Igredientes.Add("Laranja");
            Igredientes.Add("Farinha");
            Igredientes.Add("Ovos");
            Igredientes.Add("Leite");
            Igredientes.Add("Fermento");
        }
    }
}
