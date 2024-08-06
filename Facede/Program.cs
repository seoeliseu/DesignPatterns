using Facede.Facede;
using Facede.SubSistemas;

MeuFacade meuFacede = new MeuFacade();

Cliente cliente = new Cliente("Kaio Schmidt");

var resultado = meuFacede.ConcederEmprestimo(cliente,1990000.00);

Console.WriteLine($"O emprestimo para o cliente {cliente.Nome} foi {resultado}");

Console.ReadKey();
