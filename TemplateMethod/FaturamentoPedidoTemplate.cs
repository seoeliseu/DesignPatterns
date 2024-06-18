namespace TemplateMethod
{
    public abstract class FaturamentoPedidoTemplate
    {
        public void Faturar()
        {
            BaixarEstoque();
            GerarNotaFiscal();
            EnviarEmail();
            ContabilizarFaturamento();
        }

        public void BaixarEstoque()
        {
            Console.WriteLine("Estoque baixado");
        }

        public void GerarNotaFiscal()
        {
            Console.WriteLine("Nota fiscal gerada");
        }

        public void EnviarEmail()
        {
            Console.WriteLine("Email enviado");
        }

        public abstract void ContabilizarFaturamento();
    }
}
