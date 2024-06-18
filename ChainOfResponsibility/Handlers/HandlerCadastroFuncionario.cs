using ChainOfResponsibility.Concrete;
using Newtonsoft.Json.Linq;

namespace ChainOfResponsibility.Handlers
{
    public class HandlerCadastroFuncionario : BaseHandler
    {
        public override bool Handle(string request)
        {
            var json = JObject.Parse(request);

            if (json["nome"] != null && json["idade"] != null && json["sexo"] != null)
            {
                Console.WriteLine("Cadastro de funcionário realizado com sucesso.");
                return true;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
