using CreationalDesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Factory.Services
{
    public class UPIPayment: IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using UPI.");
        }
    }
}
