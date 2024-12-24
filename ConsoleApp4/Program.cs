using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Func()
        {
            Random rnd = new Random();
            for (uint x = 1; x <= 10; x++)
            {
                int number = rnd.Next(-40,+40);
                Console.WriteLine($"{x}l число{number}");
            }

        }
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();

        }
    }
}
