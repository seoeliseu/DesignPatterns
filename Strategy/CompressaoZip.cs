namespace Strategy
{
    public class CompressaoZip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine("Compactando arquivo {0} em formato ZIP", nomeArquivo);
        }
    }
}
