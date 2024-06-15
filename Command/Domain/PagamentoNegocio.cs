using Command.Entity;

namespace Command.Domain
{
    public class PagamentoNegocio(RichTextBox richText)
    {
        private readonly RichTextBox _richText = richText;

        public void ProcessarPagamento(Pagamento pagamento)
        {
            _richText.Text += $"\nProcessando pagamento do pedido {pagamento.PedidoId} no valor de {pagamento.Valor}\n";
        }
    }
}
