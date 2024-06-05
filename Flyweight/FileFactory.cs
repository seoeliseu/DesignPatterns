namespace Flyweight
{
    public class FileFactory
    {
        public static List<Arquivo> ArquivosCache { get; set; } = [];

        private FileFactory(){}

        public static Arquivo GetArquivo(string filePath)
        {
            var arquivo = ArquivosCache.FirstOrDefault(a => a.FilePath == filePath);

            if (arquivo == null)
            {
                arquivo = new Arquivo(filePath);
                ArquivosCache.Add(arquivo);
            }

            return arquivo;
        }
    }
}
