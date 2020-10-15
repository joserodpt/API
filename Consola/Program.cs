using System;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            double comprimento, largura, area;

            log("Introduz o comprimento:");
            comprimento = double.Parse(Console.ReadLine());
            log("Introduz a largura:");
            largura = double.Parse(Console.ReadLine());


            area = comprimento * largura;
            log("-+-+-+-+-+-+-+-+-");

            log("A área é " + area + " com a largura de: " + largura + " e com o comprimento de: " + comprimento);
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
