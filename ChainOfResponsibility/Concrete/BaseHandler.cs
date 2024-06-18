using ChainOfResponsibility.Interface;

namespace ChainOfResponsibility.Concrete
{
    public class BaseHandler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual bool Handle(string request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return false;
            }
        }
    }
}
