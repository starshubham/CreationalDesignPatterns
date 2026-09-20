using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Prototype
{
    public class PEmployee: IPrototype<PEmployee>
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public string Location { get; set; }

        public PEmployee Clone()
        {
            return new PEmployee
            {
                Name = this.Name,
                Department = this.Department,
                Location = this.Location
            };
        }

        public void Display()
        {
            Console.WriteLine(
                $"Name: {Name}, " +
                $"Department: {Department}, " +
                $"Location: {Location}"
            );
        }
    }
}
