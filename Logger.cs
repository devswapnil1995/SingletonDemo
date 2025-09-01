using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    //Create sealed class to avoid inheritance
    public sealed class Logger
    {
        //Create private static instance to hold single object
        private static Logger _instance;

        //Create lock to handle instance initialization check in case of multi-threading
        private static readonly object _lock = new object();


        //Create private constructor in order to restrict instance creation
        private Logger() 
        {
            Console.WriteLine("Logger Instance Created!");
        }

        //Create instance getter property with all checks
        public static Logger Instance
        {
            get
            {
                // First check (no lock) - better performance
                if (_instance == null)
                {
                    lock (_lock) // Thread-safe block
                    {
                        // Second check (inside lock) - ensures only one instance
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
        }
    }
}
