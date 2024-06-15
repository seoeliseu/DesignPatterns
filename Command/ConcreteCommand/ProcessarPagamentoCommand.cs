using Command.Domain;
using Command.Entity;
using Command.Interface;

namespace Command
{
    public class ProcessarPagamentoCommand(PagamentoNegocio pagamentoNegocio, Pagamento pagamento) : ICommand
    {
        private readonly PagamentoNegocio _pagamentoNegocio = pagamentoNegocio;
        private readonly Pagamento Pagamento = pagamento;

        public void Executar()
        {
            _pagamentoNegocio.ProcessarPagamento(Pagamento);
        }
    }
}
