using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            int canal;
        
            log("Introduzir canal de televisão:");

            try
            {
                canal = int.Parse(Console.ReadLine());
            } catch (Exception e)
            {
                log("Dado introduzido não é um número");
                return;
            }
        
            switch(canal)
            {
                case 1:
                    log("O canal " + canal + " é a RTP1");
                    break;
                case 2:
                    log("O canal " + canal + " é a RTP2");
                    break;
                case 3:
                    log("O canal " + canal + " é a SIC");
                    break;
                case 4:
                    log("O canal " + canal + " é a TVI");
                    break;
                case 5:
                    log("O canal " + canal + " é a ARTV");
                    break;
                default:
                    log("Não há nenhum canal com a posição " + canal);
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
