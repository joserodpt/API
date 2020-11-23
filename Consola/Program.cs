using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            log("Introduzir número:");
            String original = Console.ReadLine();
            String inv = reverse(original);

            log("Introduzido: " + original);
            log("Invertido: " + inv);

            if (original == inv)
            {
                log("Temos capicua!");
            } else
            {
                log("Não temos capicua!");
            }

            Console.ReadKey();
        }
        public static string reverse(String s)
        {
            char[] arraycatacteres = s.ToCharArray();
            Array.Reverse(arraycatacteres);
            return new String(arraycatacteres);
        }
        static void log(String s) {  Console.WriteLine(s);  }
    }
}
