using AbstractFactory.Domain.Enum;
using System.Collections;

namespace AbstractFactory.Domain.Products
{
    public abstract class MassaBase
    {
        public TipoMassa TipoMassa { get; set; }
        public string Nome { get; set; }
        public ArrayList Igredientes = new ArrayList();
        protected MassaBase(string nome, TipoMassa tipoMassa)
        {
            Nome = nome;
            TipoMassa = tipoMassa;
        }
    }
}
