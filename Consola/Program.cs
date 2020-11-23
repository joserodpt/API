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
            int low = 0;
            log("Introduzir número:");
            top = low = int.Parse(Console.ReadLine());
            while (executar)
            {
                log("Introduzir número:");
                int i = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    executar = false;
                    log("O maior número é o " + top);
                    log("O menor número é o " + low);
                }
                else
                {

                    if (i > top)
                    {
                        top = i;
                    } else if (i != 0 && i < low)
                    {
                        low = i;
                    }
                }
            }

            Console.ReadKey();
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
