using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Builder
{
    public class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int Experience { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Experience: {Experience}");
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
