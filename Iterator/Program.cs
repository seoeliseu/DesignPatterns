using Iterator;

var listaFornecedores = new List<Fornecedor>();

for (var i = 1; i < 1000000; i++)
{
    listaFornecedores.Add(new Fornecedor(i, $"Fornecedor {i}", $"Endereço {i}", $"Bairro {i}", $"Cidade {i}"));
}

var concreteCollection = new ConcreteCollection(listaFornecedores);

var iterator = concreteCollection.GetIterator();

var fornecedor = iterator.First(2000);

if (fornecedor != null)
{
    Console.WriteLine($"Fornecedor encontrado: {fornecedor.Nome}");
}
else
{
    Console.WriteLine("Fornecedor não encontrado.");
}