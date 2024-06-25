using Visitor.Interface;
using Visitor.PontosMapa;

namespace Visitor.Service
{
    public class ExportacaoPontoMapaService : IExportacaoPontoMapaService
    {
        public void GerarJson(PontoComercial ponto)
        {
            Console.WriteLine("Exportando ponto comercial para JSON");
        }

        public void GerarJson(PontoTaxi ponto)
        {
            Console.WriteLine("Exportando ponto de taxi para JSON");
        }

        public void GerarJson(PontoDeOnibus ponto)
        {
            Console.WriteLine("Exportando ponto de onibus para JSON");
        }
    }
}
