using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Stam");

            int j = 0;
            while (j < 100)
            {
                j++;
            }

            Console.WriteLine("Another change");
            Console.WriteLine("Another change");

        }
    }
}
