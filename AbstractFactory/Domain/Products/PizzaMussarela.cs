using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Products
{
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza de Mussarela", Enum.TipoMassa.Pizza)
        {
            Igredientes.Add("Mussarela");
            Igredientes.Add("Queijo");
            Igredientes.Add("Tomate");
            Igredientes.Add("Massa de Pizza");
        }
    }
}
