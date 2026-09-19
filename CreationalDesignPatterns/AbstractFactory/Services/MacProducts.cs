using CreationalDesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Services
{
    public class MacButton: IButton
    {
        public void Rendor()
        {
            Console.WriteLine("Rendering Mac Button");
        }
    }

    public class MacCheckbox : ICheckbox
    {
        public void Rendor()
        {
            Console.WriteLine("Rendering Mac Checkbox");
        }
    }
}
