using System;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            double raio, altura, volume, raio2;

            log("Introduzir raio:");
            raio = double.Parse(Console.ReadLine());
            log("Introduzir altura:");
            altura = double.Parse(Console.ReadLine());

            //calcular raio^2
            raio2 = Math.Pow(raio, 2.00);
            volume = 3.2222 * raio2 * altura;
           
            log("O volume de raio " + raio + " e de altura " + altura + " é: " + volume);
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
