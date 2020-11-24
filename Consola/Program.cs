using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int contar, num;
            contar = 0;
            do
            {
                log("Introduza um numero:");
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    contar++;
                }
            } while (num != 0);
            log("O total de números introduzidos foi de " + contar);

            Console.ReadKey();
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
