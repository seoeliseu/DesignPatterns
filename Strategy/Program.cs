using Strategy;

Console.WriteLine("Padrão Strategy---------\n");
CompressaoContext context = new CompressaoContext(new CompressaoRar());

Console.WriteLine("Informe o Arquivo  a ser compactado:\n");
var nomeArquivo = Console.ReadLine();

Console.WriteLine("Informe o tipo de compactação: 1 - RAR, 2 - ZIP, 3 - GZIP ---------->\n");
var opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 1)
{
    context.DefineStrategy(new CompressaoRar());
}
else if (opcao == 2)
{
    context.DefineStrategy(new CompressaoZip());
}
else
{
    context.DefineStrategy(new CompressaoGzip());
}

context.CriarArquivoCompactado(nomeArquivo);

Console.ReadKey();
