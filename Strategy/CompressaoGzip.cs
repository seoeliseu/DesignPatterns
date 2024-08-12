namespace Strategy
{
    public class CompressaoGzip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine("Compactando arquivo {0} em formato GZIP", nomeArquivo);
        }
    }
}
