using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Factory.Interfaces
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }
}
