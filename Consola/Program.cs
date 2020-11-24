using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            String id;
            int idade = 0;
            do
            {
                log("Introduza a sua idade:");
                id = Console.ReadLine();
            } while (int.TryParse(id, out idade) == false);
            log("A idade do utilizador é " + idade);

            Console.ReadKey();
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
