using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int contar, num, soma;
            contar = soma = 0;
            do
            {
                log("Introduza um numero:");
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    contar++;
                    soma += num;
                }
            } while (num != 0);
            log("A soma total de " + contar + " números introduzidos foi de " + soma);

            Console.ReadKey();
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
