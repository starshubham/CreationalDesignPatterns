using CreationalDesignPatterns.Interfaces;

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

                Console.Write("Choose Pattern: ");

                string choice = Console.ReadLine();

                //If the online execution environment you're using doesn't provide interactive console input
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
                            _ => null
                        };

                        if (paymentType == null)
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
