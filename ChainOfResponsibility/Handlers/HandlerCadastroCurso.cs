using ChainOfResponsibility.Concrete;
using Newtonsoft.Json.Linq;

namespace ChainOfResponsibility.Handlers
{
    public class HandlerCadastroCurso : BaseHandler
    {
        public override bool Handle(string request)
        {
            var json = JObject.Parse(request);

            if (json["nome"] != null && json["descricao"] != null && json["cargaHoraria"] != null)
            {
                Console.WriteLine("Cadastro de curso realizado com sucesso.");
                return true;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
