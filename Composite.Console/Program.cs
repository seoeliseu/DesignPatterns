using Composite;

var diretorioComposite = new DiretorioComposite("C:\\Kaio");

var word1 = new ArquivoWord("word1");

diretorioComposite.Adicionar(word1);
diretorioComposite.Adicionar(new ArquivoExcel("excel1 dentro kaio"));
diretorioComposite.Adicionar(new ArquivoXML("xml1 dentro kaio"));

var diretorioComposite2 = new DiretorioComposite("C:\\Kaio\\Pasta1");
var diretorioComposite3 = new DiretorioComposite("C:\\Kaio\\Pasta2");

diretorioComposite.Adicionar(diretorioComposite2);
diretorioComposite.Adicionar(diretorioComposite3);

diretorioComposite2.Adicionar(new ArquivoWord("word2 dentro pasta1"));
diretorioComposite2.Adicionar(new ArquivoExcel("pdf2 dentro pasta1"));
diretorioComposite2.Adicionar(new ArquivoExcel("excel2 dentro pasta1"));

diretorioComposite3.Adicionar(word1);

diretorioComposite.Criptografar();

diretorioComposite2.Remover(new ArquivoWord("word2 dentro pasta1"));

Console.ReadKey();
