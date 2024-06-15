using Command.Interface;

namespace Command
{
    public class Invoker(ICommand command)
    {
        private readonly ICommand _command = command;

        public void Executar()
        {
            _command.Executar();
        }
    }
}
