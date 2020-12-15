using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int a, b;
            log("Introduza a:");
            a = int.Parse(Console.ReadLine());
            log("Introduza b:");
            b = int.Parse(Console.ReadLine());
            log("A Área do círculo de raio " + (a * b) + " é: " + multiplicar(a, b));
            Console.ReadKey();
        }

        static double multiplicar(int a, int b) { return Math.PI * Math.Pow((a * b), 2.0); }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
