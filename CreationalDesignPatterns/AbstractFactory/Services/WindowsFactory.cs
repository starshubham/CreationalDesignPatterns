using CreationalDesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Services
{
    public class WindowsFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
