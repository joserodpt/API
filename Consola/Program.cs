using System;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            double classific_freq, classific_exame, resultado;

            //pedir classificações
            log("Introduzir Classificação da Frequência:");
            classific_freq = double.Parse(Console.ReadLine());
            log("Introduzir Classificação do Exame:");
            classific_exame = double.Parse(Console.ReadLine());

            //calcular media
            resultado = classific_freq*0.75 + classific_exame*0.25;
           
            log("A classificação final é de: " + resultado + " valores.");
            Console.ReadKey();
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
