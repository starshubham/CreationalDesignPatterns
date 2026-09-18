using CreationalDesignPatterns.Interfaces;
using CreationalDesignPatterns.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns
{
    internal class PaymentFactory
    {
        public IPayment CreatePayment(string paymentType)
        {
            switch(paymentType.ToLower())
            {
                case "upi":
                    return new UPIPayment();

                case "creditcard":
                    return new CreditCardPayment();

                case "paypal":
                    return new PayPalPayment();

                default:
                    throw new ArgumentException("Invalid Payment Type.");
            }
        }
    }
}
