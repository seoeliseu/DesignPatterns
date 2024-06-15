using Command.Domain;
using Command.Entity;
using Command.ConcreteCommand;

namespace Command
{
    public partial class Command : Form
    {
        private readonly PedidoNegocio _pedidoNegocio;
        private readonly PagamentoNegocio _pagamentoNegocio;

        private readonly List<Invoker> _filaComandos = [];

        public Command()
        {
            InitializeComponent();
            _pedidoNegocio = new PedidoNegocio(LogCommands);
            _pagamentoNegocio = new PagamentoNegocio(LogCommands);
        }

        private void BtnProcessarPedido_Click(object sender, EventArgs e)
        {
            var pedido = new Pedido
            {
                Id = 1,
                NomeCliente = "Seu Zé",
                Valor = 100
            };

            var invoker = new Invoker(new ProcessarPedidoCommand(_pedidoNegocio, pedido));

            _filaComandos.Add(invoker);

            LogCommands.Text += $"\nPedido do cliente {pedido.NomeCliente} adicionado à fila\n";
        }

        private void BtnProcessarPagamento_Click(object sender, EventArgs e)
        {
            var pagamento = new Pagamento
            {
                Id = 1,
                PedidoId = 1,
                Valor = 100
            };

            var invoker = new Invoker(new ProcessarPagamentoCommand(_pagamentoNegocio, pagamento));

            _filaComandos.Add(invoker);

            LogCommands.Text += $"\nPagamento do pedido {pagamento.PedidoId} adicionado à fila\n";
        }

        private void BtnProcessarDevolucao_Click(object sender, EventArgs e)
        {
            var pedido = new Pedido
            {
                Id = 2,
                NomeCliente = "Dona Amelia",
                Valor = 100
            };

            var invoker = new Invoker(new ProcessarDevolucaoCommand(_pedidoNegocio, pedido));

            _filaComandos.Add(invoker);

            LogCommands.Text += $"\nDevolução do cliente {pedido.NomeCliente} adicionada à fila\n";
        }

        private void BtnExecutarFila_Click(object sender, EventArgs e)
        {
            if (_filaComandos.Count == 0)
            {
                LogCommands.Text += $"\nNenhum comando na fila\n";
                return;
            }

            LogCommands.Text += $"\nExecutando fila de comandos\n";
            _filaComandos.ForEach(comando => comando.Executar());
            _filaComandos.Clear();
            LogCommands.Text += $"\nFila de comandos executada\n";
        }

        private void BtnLimparLog_Click(object sender, EventArgs e)
        {
            LogCommands.Text = "";
        }
    }
}
