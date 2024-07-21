namespace Singleton
{
    //Implementação basica nao funciona em codigo para implementtações multi-thread ele é falho
    public class CurrentUser
    {
        private static CurrentUser _instance;
        private CurrentUser() 
        {
            Console.WriteLine("Construtor chamado CurrentUser");
        }
        public static CurrentUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    Console.WriteLine("Instancia CurrentUser criada pela primeira Vez");
                    _instance = new CurrentUser();
                }
                return _instance;
            }
        }
    }
}
