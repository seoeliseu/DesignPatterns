namespace Proxy
{
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private readonly Funcionario _funcionario;
        //private PastaCompartilhada _pastaCompartilhada;

        public PastaCompartilhadaProxy(Funcionario funcionario)
        {
            _funcionario = funcionario;
        }

        public void OperacaoDeLeituraGravacao()
        {
            if (_funcionario.Perfil == "Administrador")
            {
                var pasta = new PastaCompartilhada();
                Console.WriteLine("Acesso permitido!");
                pasta.OperacaoDeLeituraGravacao();
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }
        }
    }
}
