
using Proxy;

Console.WriteLine("Programador");

var funcionario1 = new Funcionario("kaio","123456","Administrador");
PastaCompartilhadaProxy pastaCompartilhadaProxy = new PastaCompartilhadaProxy(funcionario1);
pastaCompartilhadaProxy.OperacaoDeLeituraGravacao();


Console.WriteLine("\nUsuario");

var funcionario2 = new Funcionario("teste","123456","Usuario");
PastaCompartilhadaProxy pastaCompartilhadaProxy2 = new PastaCompartilhadaProxy(funcionario2);
pastaCompartilhadaProxy2.OperacaoDeLeituraGravacao();


Console.WriteLine("\nGerente");

var funcionario3 = new Funcionario("teste","123456","Gerente");
PastaCompartilhadaProxy pastaCompartilhadaProxy3 = new PastaCompartilhadaProxy(funcionario3);
pastaCompartilhadaProxy3.OperacaoDeLeituraGravacao();