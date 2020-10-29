using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {

        static Double top;

        static void Main(string[] args)
        {

            log("Introduzir 1º número:");
            verificar(Double.Parse(Console.ReadLine()));
            log("Introduzir 2º número:");
            verificar(Double.Parse(Console.ReadLine()));
            log("Introduzir 3º número:");
            verificar(Double.Parse(Console.ReadLine()));

            log("O maior número têm o valor " + top);
            Console.ReadKey();
        }

        static void verificar(double v)
        { 
            if (v > top) { top = v; }
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
