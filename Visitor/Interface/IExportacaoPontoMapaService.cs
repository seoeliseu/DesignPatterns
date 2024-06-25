using Visitor.PontosMapa;

namespace Visitor.Interface
{
    public interface IExportacaoPontoMapaService
    {
        public void GerarJson(PontoComercial ponto);
        public void GerarJson(PontoTaxi ponto);
        public void GerarJson(PontoDeOnibus ponto);
    }
}
