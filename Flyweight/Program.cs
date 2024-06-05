using Flyweight;

var listaXMLImportacao = new List<ImportacaoXMLNotaFiscal>
{
    new ("XML 1", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 2", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 3", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 4", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 5", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 6", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 7", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 8", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 9", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 10", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 11", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 12", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 13", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 14", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 15", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 16", "C:\\temp\\Banco de Dados_sindicato.zip"),
    new ("XML 17", "C:\\temp\\SourceSys_DOM_2022_04_05.rar"),
    new ("XML 18", "C:\\temp\\SourceSys_DOM_2022_04_05.rar"),
    new ("XML 19", "C:\\temp\\SourceSys_DOM_2022_04_05.rar"),
    new ("XML 20", "C:\\temp\\SourceSys_DOM_2022_04_05.rar"),
    new ("XML 21", "C:\\temp\\SourceSys_DOM_2022_04_05.rar"),
    new ("XML 22", "C:\\temp\\SourceSys_DOM_2022_04_05.rar")
};

foreach (var importacaoXMLNotaFiscal in listaXMLImportacao)
{
    importacaoXMLNotaFiscal.Importar();
}


Console.ReadKey();