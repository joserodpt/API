using System;

namespace Consola
{
    class Program {
    
        static void Main(string[] args)
        {
            string nome;
            int idade;

            log("Nome:");
            nome = Console.ReadLine();
            log("Data de nascimento:");

            Boolean check = int.TryParse(Console.ReadLine(), out int datanascimento);
            if (check)
            {
                //verdadeiro, apenas numero
                //      Pegar o ano atual e substrair data de nascimento
                idade = DateTime.UtcNow.Year - datanascimento;
                log("-+-+-+-+-+-+-+-+-");

                log("O/A " + nome + " têm " + idade + " anos.");
            } else
            {
                //falso, não foi introduzido um número
                log("Dados introduzidos na data de nascimento inválidos.");
            }
            Console.ReadKey();

        }

        static void log(String s)
        {
            Console.WriteLine(s);
        }
    }
}
