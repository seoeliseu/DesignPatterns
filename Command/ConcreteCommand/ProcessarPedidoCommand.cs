using Command.Domain;
using Command.Entity;
using Command.Interface;

namespace Command.ConcreteCommand
{
    public class ProcessarPedidoCommand(PedidoNegocio pedidoNegocio, Pedido pedido) : ICommand
    {
        private readonly PedidoNegocio _pedidoNegocio = pedidoNegocio;
        private readonly Pedido Pedido = pedido;

        public void Executar()
        {
            _pedidoNegocio.ProcessarPedido(Pedido);
        }
    }
}
