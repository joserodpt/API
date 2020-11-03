using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            for (int i=1; i<=n; i++)
            {
                if (numeroPrimo(i))
                {
                    log(i + " é numero primo");
                }
            }
           
            Console.ReadKey();
        }

        static Boolean numeroPrimo(int i)
        {
            if (i%i == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
