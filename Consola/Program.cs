using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int tabuada;
            log("De quem é a tabuada?");
            tabuada = int.Parse(Console.ReadLine());
            log("Tabuada do " + tabuada + ":\n");
            for (int i = 1; i <= 10; i++) { log(tabuada + "x" + i + " = " + (tabuada*i)); }
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
