using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            quadrad();
            Console.ReadKey();
        }

        static void quadrad()
        {
            topobaixo();
            bordas();
            bordas();
            bordas();
            bordas();
            topobaixo();
        }

        static void topobaixo() { log("-------------"); }
        static void bordas() { log("|           |"); }


        static void log(String s) {  Console.WriteLine(s);  }
    }
}
