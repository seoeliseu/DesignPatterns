using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facede.SubSistemas
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine($"Consultando cliente {cliente.Nome} no cadin\n consultado com sucesso!");
            return false;
        }
    }
}
