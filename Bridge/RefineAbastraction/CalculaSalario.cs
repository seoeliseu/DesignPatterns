using Bridge.Abstraction;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.RefineAbastraction
{
    public class CalculaSalario : AbstractionGeraArquivo
    {
        public CalculaSalario(IGeraArquivo geraArquivo) : base(geraArquivo)
        {
        }

        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

            Console.WriteLine($"Valor do salário Total para o funcionário : {funcionario.Id}" + $"calculado com sucesso R$ : {funcionario.SalarioTotal} \n");

            geraArquivo.GravaArquivo(funcionario);
        }
    }
}
