using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 16)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
