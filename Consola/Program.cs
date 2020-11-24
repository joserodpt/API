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
            if (idade >= 10 && idade <= 90)
            {
                log("A idade " + idade + " está entre os 10 e os 90 anos!");
            }
            else
            {
                log("A idade " + idade + " NÃO está entre os 10 e os 90 anos!");
            }
            Console.ReadKey();
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
