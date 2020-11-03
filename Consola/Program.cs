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
            log("Introduza as vezes:");
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                log("Introduzir " + i + "º número:");
                soma = soma + int.Parse(Console.ReadLine());
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
