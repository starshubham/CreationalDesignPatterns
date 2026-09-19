using CreationalDesignPatterns.AbstractFactory.Interfaces;
using CreationalDesignPatterns.AbstractFactory.Services;
using CreationalDesignPatterns.Builder;
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
                Console.WriteLine("3. Abstract Factory Pattern");
                Console.WriteLine("4. Builder Pattern");
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

                    case "3":
                        Console.WriteLine("\nSelect Below Abstract Factory.");
                        Console.WriteLine("1. Windows Factory" +
                                        "\n2. Mac Factory");

                        Console.Write("\nEnter your choice: ");
                        string factoryChoice = Console.ReadLine();

                        switch(factoryChoice)
                        {
                            case "1":
                                IUIFactory absfactory1 = new WindowsFactory();

                                IButton winButton = absfactory1.CreateButton();
                                ICheckbox winCheckbox = absfactory1.CreateCheckbox();

                                winButton.Rendor();
                                winCheckbox.Rendor();
                                break;

                            case "2":
                                IUIFactory absfactory2 = new MacFactory();

                                IButton macButton = absfactory2.CreateButton();
                                ICheckbox macCheckbox = absfactory2.CreateCheckbox();

                                macButton.Rendor();
                                macCheckbox.Rendor();
                                break;

                            default:
                                Console.WriteLine("Invalid Choice.");
                                break;
                        }
                        break;

                    case "4":
                        Employee employee = new EmployeeBuilder()
                            .SetName("Shubham")
                            .SetRole("Software Engineer")
                            .SetExperience(5)
                            .SetLocation("India")
                            .SetSalary(150000)
                            .Build();

                        employee.Display();
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
