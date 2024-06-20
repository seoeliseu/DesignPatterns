using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ShallowCopy
{
    public class SoldadoShallowCopy : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public AcessorioShallowCopy Acessorio { get; set; }

        public SoldadoShallowCopy() { }

        public SoldadoShallowCopy(SoldadoShallowCopy s)
        {
            Nome = s.Nome;
            Acessorio = s.Acessorio;
            Arma = s.Arma;
        }

        public object Clone()
        {
            return new SoldadoShallowCopy(this);
        }
    }
}
