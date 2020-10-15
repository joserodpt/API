using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, triploa, produtobc;

            log("Introduz os 3 números:");
            a = int.Parse(Console.ReadLine());
            log("a: " + a);
            b = int.Parse(Console.ReadLine());
            log("b: " + b);
            c = int.Parse(Console.ReadLine());
            log("c: " + c);
            log("-+-+-+-+-+-+-+-+-");

            triploa = a * 3;
            produtobc = b * c;
            double quadradoc = Math.Pow(c, 2);

            log("Triplo de a: " + triploa + " | Produto de b com c: " + produtobc + " | Quadrado de C: " + quadradoc);
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
