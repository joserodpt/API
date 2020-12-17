using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
        static int lado, posx, posy;
        static String icon = "■";
        static void Main(string[] args)
        {
            log("Introduzir lado:");
            lado = int.Parse(Console.ReadLine());
            log("Introduzir PosX:");
            posx = int.Parse(Console.ReadLine());
            log("Introduzir PosY:");
            posy = int.Parse(Console.ReadLine());

            if (lado > 0)
            {
                if (lado > 1)
                {
                    lado = lado - 2;
                    quadrado();
                } else
                {
                    Console.SetCursorPosition(posx, posy);
                    log(icon);
                }
            } else
            {
                log("Um quadrado não pode ter " + lado + " lados.");
            }
            Console.ReadKey();
        }

        static void quadrado()
        {
            topo();
            bordas();
            baixo();
        }

        static void topo() {
            Console.SetCursorPosition(posx, posy);
            String print = "";
            for (int a = 0; a <= lado + 1; a++) { print += icon + " "; }
            log(print);
        }

        static void baixo()
        {
            Console.SetCursorPosition(posx, posy + lado + 1);
            String print = "";
            for (int a = 0; a <= lado + 1; a++) { print += icon + " "; }
            log(print);
        }

        static void bordas() {

            for (int lop = 0; lop <= lado; lop++) {

                Console.SetCursorPosition(posx, posy + (lop + 1));


                String print = icon;
                for (int a = 0; a <= lado * 2; a++) { print += " "; }
                print += icon;
                log(print);
            }
        }
        
        static void log(String s) {  Console.WriteLine(s);  }
    }
}
