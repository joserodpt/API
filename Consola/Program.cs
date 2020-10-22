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
                log("a > b. a: " + a);
            } else
            {
                log("a < b. b: " + b);
            }

            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
