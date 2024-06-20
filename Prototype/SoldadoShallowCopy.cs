using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class SoldadoShallowCopy : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public AcessorioShallowCopy Acessorio { get; set; }

        public SoldadoShallowCopy() {}

        public SoldadoShallowCopy(SoldadoShallowCopy s)
        {
            this.Nome = s.Nome;
            this.Acessorio = s.Acessorio;
            this.Arma = s.Arma;
        }

        public object Clone()
        {
            return new SoldadoShallowCopy(this);
        }
    }
}
