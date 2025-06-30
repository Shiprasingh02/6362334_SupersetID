using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Singleton Pattern...\n");

            Logger logger1 = Logger.GetInstance();
            logger1.Log("First message");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second message");

            // Check if both logger instances are the same
            if (logger1 == logger2)
            {
                Console.WriteLine("\n✅ Logger has only one instance.");
            }
            else
            {
                Console.WriteLine("\n❌ Logger instances are different!");
            }

            Console.ReadLine();
        }
    }
}
