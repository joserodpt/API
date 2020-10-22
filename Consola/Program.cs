using System;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            String nome;
            Double peso, calculo;

            log("Introduzir nome:");
            nome = Console.ReadLine();
            log("Introduzir peso:");
            peso = Double.Parse(Console.ReadLine());

            if (peso < 70)
            {
                calculo = 70 - peso;
                log(nome + ", ainda te falta " + calculo + "kg para o objetivo.");
                Console.ReadKey();
            }
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
