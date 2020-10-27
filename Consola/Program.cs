using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int mes;
            String nomeMes;

            log("Introduzir mês em número:");
            mes = int.Parse(Console.ReadLine());

            if (mes <= 12 && mes >= 1)
            {
                nomeMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
                log("O mês " + mes + " (" + nomeMes + ") têm " + DateTime.DaysInMonth(DateTime.Now.Year, mes) + " dias.");
            } else
            {
                log("Mês inválido");
            }
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
