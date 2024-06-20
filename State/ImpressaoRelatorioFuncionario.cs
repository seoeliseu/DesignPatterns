namespace State
{
    internal class ImpressaoRelatorioFuncionario : IStateImpressao
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo relatório de funcionários...");
            Console.WriteLine("Funcionario 1");
            Console.WriteLine("Funcionario 2");
            Console.WriteLine("Funcionario 3");
            Console.WriteLine("Funcionario 4");
        }
    }
}
