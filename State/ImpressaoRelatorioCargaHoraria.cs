namespace State
{
    internal class ImpressaoRelatorioCargaHoraria : IStateImpressao
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo relatório de carga horária...");
            Console.WriteLine($"Data: {DateTime.Now}");
            Console.WriteLine($"Data: {DateTime.Now}");
            Console.WriteLine($"Data: {DateTime.Now}");
            Console.WriteLine($"Data: {DateTime.Now}");
            Console.WriteLine($"Data: {DateTime.Now}");
            Console.WriteLine($"Data: {DateTime.Now}");

            SalvarPdf();
        }

        public void SalvarPdf()
        {
            Console.WriteLine("Salvando PDF...");
        }
    }
}
