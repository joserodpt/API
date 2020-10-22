using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            List<Double> lista = new List<Double>();

            log("Introduzir 1º número:");
            lista.Add(Double.Parse(Console.ReadLine()));
            log("Introduzir 2º número:");
            lista.Add(Double.Parse(Console.ReadLine()));
            log("Introduzir 3º número:");
            lista.Add(Double.Parse(Console.ReadLine()));

            Double max = lista.Max();

            log("O maior número têm o valor " + max);
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
