namespace Flyweight
{
    public class ImportacaoXMLNotaFiscal (string xml, string filepath)
    {
        public string XML { get; set; } = xml;
        public string FilePathPreSet { get; set; } = filepath;

        public void Importar()
        {
            var arquivo = FileFactory.GetArquivo(FilePathPreSet);

            Console.WriteLine($"Importando XML: {XML} usando pre-set: {arquivo.FilePath}");
        }
    }
}
