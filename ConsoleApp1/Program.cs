using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   /// <summary>
    /// Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20.
    /// </summary>
    internal class Program
    {
        static void Fou()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{20}\t");
        }   }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
