using System;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            Double a, b;

            log("Introduzir a:");
            a = Double.Parse(Console.ReadLine());
            log("Introduzir b:");
            b = Double.Parse(Console.ReadLine());

            if (a > b)
            {
                log("O maior número é o a: " + a);
            } else
            {
                log("O maior número é o b: " + b);
            }
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
