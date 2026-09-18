using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Interfaces
{
    internal interface IPayment
    {
        void Pay(decimal amount);
    }
}
