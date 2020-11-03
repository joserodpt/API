using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            for (int i=2; i<=1000; i++)
            {
                if (numeroPrimo(i))
                {
                    log(i + " é numero primo");
                }
            }
           
            Console.ReadKey();
        }

        static Boolean numeroPrimo(int numero)
        {
            if (numero == 1) return false; //1 não é primo
            if (numero == 2) return true; //2 é primo
            if (numero % 2 == 0) return false; //número inteiro     

            //TODO

            return true;
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
