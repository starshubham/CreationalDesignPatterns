using CreationalDesignPatterns.Factory;
using CreationalDesignPatterns.Factory.Interfaces;
using CreationalDesignPatterns.Singleton;

namespace CreationalDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("===== Creational Design Patterns =====");
                Console.WriteLine("1. Singleton Design Pattern");
                Console.WriteLine("2. Factory Method Pattern");
                Console.WriteLine("6. Exit");

                Console.Write("\nChoose Pattern: ");

                string choice = Console.ReadLine();

                //If you're using the online execution environment and it doesn't provide interactive console input then use below
                //if (choice == null)
                //{
                //    return;
                //}

                switch (choice)
                {
                    case "1":
                        Logger logger1 = Logger.Instance;
                        Logger logger2 = Logger.Instance;

                        logger1.Log("Application started.");

                        Console.WriteLine("Is only one instance is created?");
                        Console.WriteLine(ReferenceEquals(logger1, logger2));
                        break;

                    case "2":
                        PaymentFactory factory = new PaymentFactory();

                        Console.WriteLine("\nChoose any one of the below payment method: ");
                        Console.WriteLine("1. UPI" +
                                        "\n2. Credit Card" +
                                        "\n3. PayPal");

                        Console.Write("Enter your choice: ");
                        string paymentchoice = Console.ReadLine();

                        string paymentType = paymentchoice switch
                        {
                            "1" => "upi",
                            "2" => "creditcard",
                            "3" => "paypal",
                            _ => "Invalid"
                        };

                        if (paymentType == "Invalid")
                        {
                            Console.WriteLine("Invalid payment type.");
                            break;
                        }

                        IPayment payment = factory.CreatePayment(paymentType);
                        payment.Pay(5000);
                        break;

                    case "6":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;

                }
            }
        }
    }
}
