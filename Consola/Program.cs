using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            double soma, media;
            soma = 0;
            log("Introduza o número N:");
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                soma = soma + i;
            }
            media = soma / n;
            log("A média de " + n + " números inteiros é: " + media);

            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
