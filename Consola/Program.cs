using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int i = 1;
            Boolean par = false;
            while (i < 16)
            {
                if (par)
                {
                    Console.WriteLine(i);
                    par = false;
                } else
                {
                    par = true;
                }
                i++;
            }

            Console.ReadKey();
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
