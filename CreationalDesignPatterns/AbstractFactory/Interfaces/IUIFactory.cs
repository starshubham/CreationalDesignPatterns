using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Interfaces
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
