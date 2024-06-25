using Visitor.Interface;

namespace Visitor.PontosMapa
{
    public class PontoComercial(string nome) : IPontoMapa
    {
        public string Nome { get; set; } = nome;

        public void GerarJson(IExportacaoPontoMapaService visitor)
        {
            visitor.GerarJson(this);
        }
    }
}
