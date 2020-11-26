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
            log("Soma: " + soma(a, b));
            Console.ReadKey();
        }

        static int soma(int a, int b) { return a + b; }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
