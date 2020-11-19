using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            Boolean executar = true;
            int top = 0;
            while (executar)
            {
                log("Introduzir numero:");
                int i = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    executar = false;
                    log("O maior número é o " + top);
                }
                else
                {
                    if (i > top) { top = i; }
                }
            }

            Console.ReadKey();
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
