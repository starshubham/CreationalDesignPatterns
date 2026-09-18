using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns
{
    internal sealed class Logger
    {
        // The class creates its own instance.
        public static readonly Logger _instance = new Logger();

        // this prevents other classes from doing:
        // new Logger();
        private Logger() { }

        public static Logger Instance
        {
            get { return _instance; }
        }

        public void Log(string message)
        {
            Console.WriteLine($"LOG: {message}");
        }
    }
}
