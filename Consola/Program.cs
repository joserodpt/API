using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            log("Tabuada do 2:\n");
            for (int i = 1; i <= 10; i++)
                log("2x" + i + " -> " + (2*i));

            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
