using Facede.SubSistemas;

namespace Facede.Facede
{
    public class MeuFacade
    {
        private LimiteDeCredito limite;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        public MeuFacade()
        {
            limite = new LimiteDeCredito();
            serasa = new Serasa();
            cadin = new Cadin();
            cadastro = new Cadastro();
        }

        public bool ConcederEmprestimo(Cliente cliente, double valor)
        {
            Console.WriteLine($"Iniciando análise de crédito para {cliente.Nome}");
            cadastro.CadastrarCliente(cliente);

            bool concederEmprestimo = true;

            if (serasa.EstaNoSerasa(cliente))
            {
                Console.WriteLine("Cliente está no Serasa, empréstimo negado!");
                concederEmprestimo = false;
            }
            else if (cadin.EstaNoCadin(cliente))
            {
                Console.WriteLine("Cliente está no Cadin, empréstimo negado!");
                concederEmprestimo = false;
            }
            else if (!limite.TemLimiteDisponivel(cliente,valor))
            {
                Console.WriteLine("Cliente não tem limite disponível, empréstimo negado!");
                concederEmprestimo = false;
            }

            return concederEmprestimo;
        }
    }
}
