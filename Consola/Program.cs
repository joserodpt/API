using System;
using System.Runtime.InteropServices.ComTypes;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            Double lado1, lado2;

            log("Introduzir lado1:");
            lado1 = Double.Parse(Console.ReadLine());
            log("Introduzir lado2:");
            lado2 = Double.Parse(Console.ReadLine());

            if (lado1 == lado2)
            {
                //quadrado
                double quadrado = lado1*lado2;
                log("Área do quadrado: " + quadrado);
            } else
            {
                //retangulo
                log("Área do retângulo: " + lado1*lado2);
            }

            Console.ReadKey();

        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
