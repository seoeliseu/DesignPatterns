﻿namespace ChainOfResponsibility.Interface
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        bool Handle(string request);
    }
}
