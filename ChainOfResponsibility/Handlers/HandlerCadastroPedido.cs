using ChainOfResponsibility.Concrete;
using Newtonsoft.Json.Linq;

namespace ChainOfResponsibility.Handlers
{
    public class HandlerCadastroPedido : BaseHandler
    {
        public override bool Handle(string request)
        {
            var json = JObject.Parse(request);

            if (json["cliente"] != null && json["produto"] != null && json["quantidade"] != null)
            {
                Console.WriteLine("Cadastro de pedido realizado com sucesso.");
                return true;
            }
            else
            {
                return base.Handle(request);
            }
        }

    }
}
