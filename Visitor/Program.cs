using Visitor.Service;
using Visitor.Interface;
using Visitor.PontosMapa;

var listaPontosNoMapa = new List<IPontoMapa>
{
    new PontoTaxi("Museu de Arte Moderna", -10.4454534534, -20.312312312),
    new PontoTaxi("Praça da Sé", -10.4454534534, -20.312312312),
    new PontoComercial("Merceadoria do zezinho"),
    new PontoComercial("Alabama"),
    new PontoDeOnibus("N° 1455")
};

var service = new ExportacaoPontoMapaService();

foreach (var ponto in listaPontosNoMapa)
{
    ponto.GerarJson(service);
}

