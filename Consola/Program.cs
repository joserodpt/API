using System;
using System.Runtime.InteropServices.ComTypes;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            Double compra, venda, transacao;

            log("Introduzir preço de compra:");
            compra = Double.Parse(Console.ReadLine());
            log("Introduzir preço de venda:");
            venda = Double.Parse(Console.ReadLine());

            transacao = venda - compra;

            if (venda > compra)
            {
                //lucro
                log("A Transação deu lucro de " + transacao + " euros.");
            }
            else
            {
                if (venda == compra)
                {
                    log("Não houve prejuízo, pois o preço de compra e de venda são iguais");
                    return;
                }
                //prejuizo
                log("A Transação deu prejuízo de " + transacao + " euros.");
            }

            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
