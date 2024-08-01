using Adapter.Adapter;
using Adapter.Target;

string[,] alunosArray = new string[5, 4]
{
    {"1", "João", "Matemática", "1000"},
    {"2", "Maria", "Português", "1200"},
    {"3", "José", "História", "800"},
    {"4", "Pedro", "Geografia", "1100"},
    {"5", "Paulo", "Inglês", "1300"}
};

ITarget target = new AlunoAdapter();

Console.WriteLine("SistemaMensalidades passo o array de string para o adapter\n");

target.ProcessaCalculoMensalidade(alunosArray);

Console.ReadKey();
