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

            switch (mes)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    nomeMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
                    log("O mês " + mes + " (" + nomeMes + ") têm " + DateTime.DaysInMonth(DateTime.Now.Year, mes) + " dias.");
                    break;
                default:
                    log("Mês inválido");
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
