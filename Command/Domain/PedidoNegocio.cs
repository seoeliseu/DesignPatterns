using Command.Entity;

namespace Command.Domain
{
    public class PedidoNegocio(RichTextBox richText)
    {
        private readonly RichTextBox _richText = richText;

        public void ProcessarPedido(Pedido pedido)
        {
            _richText.Text += $"\nProcessando pedido do pedido {pedido.Id} no valor de {pedido.Valor}\n";
        }

        public void ProcessarDevolucao(Pedido pedido)
        {
            _richText.Text += $"\nProcessando devolução do pedido {pedido.Id} no valor de {pedido.Valor}\n";
        }
    }
}
