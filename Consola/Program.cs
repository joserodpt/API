using System;
using System.Runtime.InteropServices.ComTypes;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int a;

            log("Introduzir a:");
            a = int.Parse(Console.ReadLine());
           
            //verificar se é par ou ímpar com o resto da divisão
            if (a%2 == 0)
            {
                //par
                log("O número é par");
            } else
            {
                //ímpar
                log("O número é impar");
            }

            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
