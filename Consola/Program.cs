using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            double contar, num, soma;
            double media;
            contar = soma = 0;
            do
            {
                log("Introduza um numero:");
                num = double.Parse(Console.ReadLine());
                if (num != 0)
                {
                    contar++;
                    soma += num;
                }
            } while (num != 0);
            media = soma / contar;
            log("A soma total de " + contar + " números introduzidos foi de " + soma + "\ne a média é de " + media);

            Console.ReadKey();
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
