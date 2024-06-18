using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility.Concrete
{
    public class Handler
    {
        public static bool Handle(string request)
        {
            var handlerCadastroCurso = new HandlerCadastroCurso();
            var handlerCadastroPedido = new HandlerCadastroPedido();
            var handlerCadastroFuncionario = new HandlerCadastroFuncionario();

            handlerCadastroCurso.SetNext(handlerCadastroPedido);
            handlerCadastroPedido.SetNext(handlerCadastroFuncionario);

            return handlerCadastroCurso.Handle(request);
        }
    }
}
