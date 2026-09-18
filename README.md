**What are Creational Design Patterns?**
Creational Design Patterns focus on how objects are created.

Pattern	Main Purpose	Easy Meaning
Singleton	One instance	"Only one object"
Factory Method	Create one of several related objects	"You tell me what you need; I'll create it"
Abstract Factory	Create families of related objects	"I'll create a complete family"
Builder	Construct complex objects step-by-step	"Build the object gradually"
Prototype	Create objects by cloning existing objects	"Copy an existing object"


**1. What is Singleton?**
The Singleton Pattern ensures that:
A class has only one instance throughout the application and provides a global access point to that instance.

Real-world examples
Suppose your application needs one:
•	Configuration manager 
•	Application-wide cache 
•	Logger 
•	Application settings manager 
You don't necessarily want hundreds of instances of these objects.

**Why is the Singleton constructor private?**
Because if the constructor were public, multiple objects could be created. A private constructor prevents direct instantiation.

Singleton in Modern .NET
In actual ASP.NET Core applications, you will often use Dependency Injection instead of manually implementing Singleton.
For example:
builder.Services.AddSingleton<ILoggerService, LoggerService>();

The .NET DI container manages the singleton lifetime.
So in modern ASP.NET Core:
Singleton lifetime in DI is usually preferred over manually implementing Singleton.

**2. Factory Method Pattern**
Suppose we have different payment methods:
Payment
   |
   +-- CreditCardPayment
   +-- UPIPayment
   +-- PayPalPayment

Without a factory:
Payment payment;

if (paymentType == "UPI")
{
    payment = new UPIPayment();
}
else if (paymentType == "CreditCard")
{
    payment = new CreditCardPayment();
}
else
{
    payment = new PayPalPayment();
}

The client is responsible for deciding which object to create.
This can become difficult to maintain.

Factory Method Idea
Instead, create a factory abstraction responsible for creating the appropriate object.
Client
    |
   ▼
PaymentFactory
   |
   +---- UPIPayment
   +---- CreditCardPayment
   +---- PayPalPayment

   
