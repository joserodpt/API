using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            Double a, b;
            int escolha;

            log("~ Calculadora Simplex ~");
            log("Introduzir número1:");
            a = Double.Parse(Console.ReadLine());
            log("Introduzir número2:");
            b = Double.Parse(Console.ReadLine());
            log("Operações possíveis:" +
                "\n1 - Somar" +
                "\n2 - Subtrair" +
                "\n3 - Multiplicar" +
                "\n4 - Dividir" +
                "\n(Digita a opção pretendida)");
            escolha = int.Parse(Console.ReadLine());

        
            switch(escolha)
            {
                case 1:
                    log("A soma dá: " + (a+b));
                    break;
                case 2:
                    log("A subtração dá: " + (a - b));
                    break;
                case 3:
                    log("A multiplicação dá: " + (a * b));
                    break;
                case 4:
                    log("A divisão dá: " + (a/b));
                    break;
                default:
                    log("Opção não reconhecida.");
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
