using Singleton;

class Program
{
    static void Main(string[] args)
    {
        // Exmplo implementação basica
        var usuarioKaio = CurrentUser.Instance;
        Console.WriteLine($"Primeira instancia {usuarioKaio}");

        var usuarioEliseu = CurrentUser.Instance;
        Console.WriteLine($"Segunda instancia {usuarioEliseu}");

        if (usuarioKaio == usuarioEliseu)
        {
            Console.WriteLine("Instancias iguais");
        }
        else
        {
            Console.WriteLine("Instancias diferentes");
        }

        // Exemplo implementação multi-thread
        Parallel.Invoke(() => Thread1(), () => Thread2());

        Console.Read();
    }

    private static void Thread1()
    {
        var usuarioKaioMulti = CurrentUserMulti.Instance;
    }

    private static void Thread2()
    {
        var usuarioEliseuMulti = CurrentUserMulti.Instance;
    }
}