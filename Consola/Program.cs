using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            String frase;
            int palavras = 0, espacos = 0;
            log("Insere a frase:");
            frase = Console.ReadLine();

            //verificar se frase é vazia
            if (String.IsNullOrEmpty(frase))
            {
                log("Frase introduzida é vazia.");
                return;
            }

            for (int i = 0; i <= frase.Length - 1; i++) { 
                if (Char.IsWhiteSpace(frase[i]))
                {
                    espacos++;
                }
            }
               
            palavras = espacos + 1;
                
            log("A frase de " + frase.Length + " caracteres têm\n> " + espacos + " espaços\n> " + palavras + " palavras");
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
