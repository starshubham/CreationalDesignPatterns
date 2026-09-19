using CreationalDesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Services
{
    public class WindowsButton: IButton
    {
        public void Rendor()
        {
            Console.WriteLine("Rendering Windows Button");
        }
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Rendor()
        {
            Console.WriteLine("Rendering Windows Checkbox");
        }
    }
}
