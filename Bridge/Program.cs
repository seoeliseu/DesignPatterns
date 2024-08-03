using Bridge.ConcreteImplementor;
using Bridge.Domain;
using Bridge.RefineAbastraction;

CalculaSalario calculaSalario = new CalculaSalario(new GeraXML());

Funcionario funcionario = new Funcionario
{
    Id = 1,
    Nome = "João",
    SalarioBase = 1000,
    Incentivo = 500
};

calculaSalario.ProcessaSalarioFuncionario(funcionario);

calculaSalario = new CalculaSalario(new GeraJson());

calculaSalario.ProcessaSalarioFuncionario(funcionario);

Console.ReadKey();
