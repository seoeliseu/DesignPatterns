using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class FaturamentoClienteCPF : FaturamentoPedidoTemplate
    {
        public override void ContabilizarFaturamento()
        {
            Console.WriteLine("Faturamento contabilizado para cliente CPF");
        }
    }
}
