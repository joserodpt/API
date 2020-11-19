using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int i = 1;
            while(i<16)
            {
                Console.WriteLine(i);
                i++;    
            }

            Console.ReadKey();
        }

        static Boolean numeroPrimo(int numero)
        {
            //contador de restos 0
            int contador = 0;
            for (int j=1; j <= numero; j++)
            {
                //achar divisões que dão resto 0
                if (numero % j == 0) { contador++; }
            }
            //número primo é o resultado de 2 divisões, por 1 e pelo próprio, portanto vai ter 2 restos
            return contador == 2;
        }

        static void log(String s) {  Console.WriteLine(s);  }
    }
}
