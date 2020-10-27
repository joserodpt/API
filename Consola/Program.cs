using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            log("Introduza o peso:");
            int peso = int.Parse(Console.ReadLine());
            log("Selecione o sexo:\n1-Masculino\n2-Feminino");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                //masculino
                log("Para o sexo Masculino:");
                if (dentro(peso, 0, 50))
                {
                    log("Peso: " + peso + " | Classificação: Muito Magro");
                }
                else if (dentro(peso, 51, 60))
                {
                    log("Peso: " + peso + " | Classificação: Magro");
                }
                else if (dentro(peso, 61, 75))
                {
                    log("Peso: " + peso + " | Classificação: Normal");
                }
                else if (dentro(peso, 76, 90))
                {
                    log("Peso: " + peso + " | Classificação: Forte");
                }
                else if (dentro(peso, 91, 180))
                {
                    log("Peso: " + peso + " | Classificação: Gordo");
                }
                else
                {
                    //foradaescala
                    log("Peso: " + peso + " | Classificação: Fora de Escala");
                }
            } else
            {
                //feminino
                log("Para o sexo Feminino:");
                if (dentro(peso, 0, 40))
                {
                    log("Peso: " + peso + " | Classificação: Muito Magra");
                }
                else if (dentro(peso, 41, 50))
                {
                    log("Peso: " + peso + " | Classificação: Magra");
                }
                else if (dentro(peso, 51, 60))
                {
                    log("Peso: " + peso + " | Classificação: Normal");
                }
                else if (dentro(peso, 61, 70))
                {
                    log("Peso: " + peso + " | Classificação: Forte");
                }
                else if (dentro(peso, 71, 120))
                {
                    log("Peso: " + peso + " | Classificação: Gorda");
                }
                else
                {
                    //foradaescala
                    log("Peso: " + peso + " | Classificação: Fora de Escala");
                }
            }

            /*
            switch (opcao)
            {
                case 1:
                    //masculino
                    log("Para o sexo Masculino:");
                    if (dentro(peso, 0, 50))
                    {
                        log("Peso: " + peso + " | Classificação: Muito Magro");
                    } else if (dentro(peso, 51, 60))
                    {
                        log("Peso: " + peso + " | Classificação: Magro");
                    }
                    else if (dentro(peso, 61, 75))
                    {
                        log("Peso: " + peso + " | Classificação: Normal");
                    }
                    else if (dentro(peso, 76, 90))
                    {
                        log("Peso: " + peso + " | Classificação: Forte");
                    }
                    else if (dentro(peso, 91, 180))
                    {
                        log("Peso: " + peso + " | Classificação: Gordo");
                    }
                    else
                    {
                        //foradaescala
                        log("Peso: " + peso + " | Classificação: Fora de Escala");
                    }
                    break;
                case 2:
                    //feminino
                    log("Para o sexo Feminino:");
                    if (dentro(peso, 0, 40))
                    {
                        log("Peso: " + peso + " | Classificação: Muito Magra");
                    }
                    else if (dentro(peso, 41, 50))
                    {
                        log("Peso: " + peso + " | Classificação: Magra");
                    }
                    else if (dentro(peso, 51, 60))
                    {
                        log("Peso: " + peso + " | Classificação: Normal");
                    }
                    else if (dentro(peso, 61, 70))
                    {
                        log("Peso: " + peso + " | Classificação: Forte");
                    }
                    else if (dentro(peso, 71, 120))
                    {
                        log("Peso: " + peso + " | Classificação: Gorda");
                    } else
                    {
                        //foradaescala
                        log("Peso: " + peso + " | Classificação: Fora de Escala");
                    }
                    break;
            }
            */
            Console.ReadKey();
        }

        static Boolean dentro(int numero, int inicio, int fim)
        {
            return (numero >= inicio && numero <= fim);
        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
