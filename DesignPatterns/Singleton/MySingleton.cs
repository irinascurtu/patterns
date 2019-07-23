using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class MySingleton
    {
        private static int counter = 0;
        private static MySingleton instance = null;

        //as a property or it can be a method
        public static MySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MySingleton();
                }
                return instance;
            }
        }

        private MySingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"Instance number: {counter}");
        }
    }
}
