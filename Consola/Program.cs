using System;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            double euros, escudos;
            double taxa_de_conversao = 200.482;

            log("Introduz euros:");
            euros = double.Parse(Console.ReadLine());
            escudos = euros * taxa_de_conversao;
            log("-+-+-+-+-+-+-+-+-");

            log("O valor de " + euros + " euros em escudos é: " + escudos);
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
