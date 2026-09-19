using CreationalDesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Factory.Services
{
    public class PayPalPayment: IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }
}
