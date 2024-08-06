using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facede.SubSistemas
{
    public class LimiteDeCredito
    {
        public bool TemLimiteDisponivel(Cliente cliente, double valor)
        {
            Console.WriteLine($"Consultando limite de crédito do cliente {cliente.Nome}\n consultado com sucesso!");

            if (valor> 200000.00)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
