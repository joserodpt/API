using System;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            double cateto1, cateto2, hipotenusa;

            //pedir classificações
            log("Introduzir cateto1:");
            cateto1 = double.Parse(Console.ReadLine());
            log("Introduzir cateto2:");
            cateto2 = double.Parse(Console.ReadLine());

            //catetos o quadrado dos catetos
            double cateto1aoquadrado = Math.Pow(cateto1, 2.0);
            double cateto2aoquadrado = Math.Pow(cateto2, 2.0);
            hipotenusa = Math.Sqrt(cateto1aoquadrado + cateto2aoquadrado);
           
            log("A hipotenusa é: " + hipotenusa);
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
