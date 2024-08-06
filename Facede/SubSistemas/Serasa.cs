using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facede.SubSistemas
{
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            Console.WriteLine($"Consultando cliente {cliente.Nome} no serasa\n consultado com sucesso!");
            return false;
        }
    }
}
