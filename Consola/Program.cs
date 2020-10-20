using System;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            Double teste1, teste2, teste3, media;

            //pedir notas dos 3 testes
            log("Introduzir nota do teste 1:");
            teste1 = Double.Parse(Console.ReadLine());
            log("Introduzir nota do teste 2:");
            teste2 = Double.Parse(Console.ReadLine());
            log("Introduzir nota do teste 3:");
            teste3 = Double.Parse(Console.ReadLine());

            //calcular media
            media = (teste1 + teste2 + teste3) / 3;
           
            log("A média dos 3 testes é de: " + Math.Round(media, 2) + " valores.");
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
