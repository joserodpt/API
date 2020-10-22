using System;
using System.Runtime.InteropServices.ComTypes;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            Double a;

            log("Introduzir a:");
            a = Double.Parse(Console.ReadLine());
           
            if (a >= 9.5)
            {
                //positiva
                log("A nota é positiva.");
            } else
            {
                //negativa
                log("A nota é negativa.");
                if (a >= 7 && a <= 9)
                {
                    //dentro de intervalo
                    log("A nota está dentro do intervalo de 7 a 9");
                }
            }

            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
