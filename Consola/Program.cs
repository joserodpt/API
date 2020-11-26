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
            log("Multiplicação: " + multiplicar(a, b));
            Console.ReadKey();
        }

        static int multiplicar(int a, int b) { return a * b; }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
