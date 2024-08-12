namespace Strategy
{
    public class CompressaoRar : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine("Compactando arquivo {0} em formato RAR", nomeArquivo);
        } 
    }
}
