namespace Singleton
{
    public class CurrentUserMulti
    {
        private static CurrentUserMulti _instance;
        private static readonly object _lock = new object();
        private CurrentUserMulti()
        {
            Console.WriteLine("Construtor chamado CurrentUserMulti");
        }
        public static CurrentUserMulti Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            Console.WriteLine("Instancia CurrentUserMulti criada pela primeira Vez");
                            _instance = new CurrentUserMulti();
                        }
                    }
                }
                return _instance;

            }
        }
    }
}
