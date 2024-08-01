using Adapter.Domain;

namespace Adapter.Adaptee
{
    public class SistemaMensalidades
    {
        public void CalculaMensalidade(List<Aluno> listaAlunos)
        {
            foreach (Aluno aluno in listaAlunos)
            {
                Console.WriteLine($"Calculando mensalidade do aluno {aluno.Nome}, valor {aluno.Mensalidade}");
            }
        }
    }
}
