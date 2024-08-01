using Adapter.Adaptee;
using Adapter.Domain;
using Adapter.Target;

namespace Adapter.Adapter
{
    public class AlunoAdapter : ITarget
    {
        private SistemaMensalidades _sistemaMensalidades = new SistemaMensalidades();
        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            string id = null;
            string nome = null;
            string curso = null;
            string mensalidade = null;

            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        id = alunosArray[i, j];
                    }
                    else if (j == 1)
                    {
                        nome = alunosArray[i, j];
                    }
                    else if (j == 2)
                    {
                        curso = alunosArray[i, j];
                    }
                    else if (j == 3)
                    {
                        mensalidade = alunosArray[i, j];
                    }
                }
                listaAlunos.Add(new Aluno(int.Parse(id), nome, curso, decimal.Parse(mensalidade)));
            }

            Console.WriteLine("O Adapter converteu o Array[] para List<> de alunos\n");

            Console.WriteLine("E delegou ao sistemaMensalidades o processamento");

            _sistemaMensalidades.CalculaMensalidade(listaAlunos);
        }
    }
}
