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
            quadrad();
            Console.ReadKey();
        }

        static void quadrad()
        {
            topobaixo();
            for (int a = 0; a < lado; a++) { bordas(); }
            topobaixo();
        }

        static void topobaixo() {
            String print = "";
            for (int a = 0; a <= lado + 2; a++) { print += icon + " "; }
            log(print);
        }
        static void bordas() {
            String print = icon;
            for (int a = 0; a <= lado*2 + 2; a++) { print += " "; }
            print += icon;
            log(print);
        }


        static void log(String s) {  Console.WriteLine(s);  }
    }
}
