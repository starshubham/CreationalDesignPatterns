using CreationalDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Services
{
    internal class PayPalPayment: IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }
}
