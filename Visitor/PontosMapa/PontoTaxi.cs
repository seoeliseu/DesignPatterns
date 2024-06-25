using Visitor.Interface;

namespace Visitor.PontosMapa
{
    public class PontoTaxi(string nome, double latitude, double longitude) : IPontoMapa
    {
        public double Latitude { get; set; } = latitude;
        public double Longitude { get; set; } = longitude;
        public string Nome { get; set; } = nome;
        public string? Contato { get; set; }

        public void GerarJson(IExportacaoPontoMapaService visitor)
        {
            visitor.GerarJson(this);
        }
    }
}
