using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            //todo
            log("Qual é o saldo?");
            int saldo = int.Parse(Console.ReadLine());
            log("Quantas peças têm?");
            int pecas = int.Parse(Console.ReadLine());

            int preco = 80 * pecas;
            saldo = saldo - preco;

            if (saldo > 0)
            {
                //possivel
                log("A compra é possível\nAinda sobra " + saldo + " unidades monetárias.");
            } else
            {
                //faltadinheiro
                log("A compra não é possível\nFaltam " + saldo + " unidades monetárias.");
            }


            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
