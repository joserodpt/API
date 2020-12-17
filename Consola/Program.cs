using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
        static int lado;
        static String icon = "■";
        static void Main(string[] args)
        {
            log("Introduzir lado:");
            lado = int.Parse(Console.ReadLine());

            if (lado > 0)
            {
                if (lado > 1)
                {
                    lado = lado - 2;
                    quadrad();
                } else
                {
                    log(icon);
                }
            } else
            {
                log("Um quadrado não pode ter " + lado + " lados.");
            }
            Console.ReadKey();
        }

        static void quadrad()
        {
            topobaixo();
            bordas();
            topobaixo();
        }

        static void topobaixo() {
            String print = "";
            for (int a = 0; a <= lado + 1; a++) { print += icon + " "; }
            log(print);
        }
        static void bordas() {
            for(int lop = 0; lop < lado; lop++) {
                String print = icon;
                for (int a = 0; a <= lado * 2; a++) { print += " "; }
                print += icon;
                log(print);
            }
        }


        static void log(String s) {  Console.WriteLine(s);  }
    }
}
