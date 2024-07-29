using AbstractFactory.Domain.Enum;

namespace AbstractFactory.Domain.Products
{
    public abstract class Bolo : MassaBase
    {
        public Bolo(string nome,TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}
