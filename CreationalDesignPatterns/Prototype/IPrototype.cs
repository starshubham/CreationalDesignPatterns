using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Prototype
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
