namespace TemplateMethod
{
    public class FaturamentoClienteCNPJ : FaturamentoPedidoTemplate
    {
        public override void ContabilizarFaturamento()
        {
            Console.WriteLine("Faturamento contabilizado para cliente CNPJ");
        }
    }
}
