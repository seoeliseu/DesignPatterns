using Iterator;
using System.Diagnostics;

var listaFornecedores = new List<Fornecedor>();

for (var i = 1; i < 30000; i++)
{
    listaFornecedores.Add(new Fornecedor(i, $"Fornecedor {i}", $"Endereço {i}", $"Bairro {i}", $"Cidade {i}"));
}

var concreteCollection = new ConcreteCollection(listaFornecedores);

var iterator = concreteCollection.GetIterator();

var stopwatch = Stopwatch.StartNew();
Console.WriteLine("Buscando fornecedor na árvore...");
var fornecedor = iterator.First(988);
stopwatch.Stop();

var stopWatchList = Stopwatch.StartNew();
Console.WriteLine("Buscando fornecedor na lista...");
foreach (var item in listaFornecedores)
{
    Console.WriteLine($"Fornecedor: {item.Id}");
    if (item.Id == 988)
    {
        break;
    }
}

stopWatchList.Stop();

if (fornecedor != null)
{
    Console.WriteLine($"Fornecedor encontrado: {fornecedor.Nome}");
}
else
{
    Console.WriteLine("Fornecedor não encontrado.");
}

Console.WriteLine($"Tempo de execução Tree: {stopwatch.ElapsedMilliseconds} ms");
Console.WriteLine($"Tempo de execução List: {stopWatchList.ElapsedMilliseconds} ms");
