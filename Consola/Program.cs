using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            log("Introduzir dia da semana:");
            int dia = int.Parse(Console.ReadLine());
            switch(dia)
            {
                case 1:
                    log("É domingo!");
                    break;
                case 2:
                    log("É segunda feira!");
                    break;
                case 3:
                    log("É terça feira!");
                    break;
                case 4:
                    log("É quarta feira!");
                    break;
                case 5:
                    log("É quinta feira!");
                    break;
                case 6:
                    log("É sexta feira!");
                    break;
                case 7:
                    log("É sábado!");
                    break;
             
            }


            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
