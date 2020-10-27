using System;
using System.Runtime.InteropServices.ComTypes;

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

            if (escolha == 1)
            {
                log("A soma dá: " + (a + b));
            }
            else if (escolha == 2)
            {
                log("A subtração dá: " + (a - b));
            }
            else if (escolha == 3)
            {
                log("A multiplicação dá: " + (a * b));
            }
            else if (escolha == 4)
            {
                log("A divisão dá: " + (a / b));
            } else
            {
                log("Opção não reconhecida.");
            }

            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
