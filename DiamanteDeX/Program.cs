using System.Collections;

namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Trabalho 01 - Diamante de X");
                Console.Write("Insira um número ímpar inteiro: ");
                int entrada = int.Parse(Console.ReadLine());

                if (entrada % 2 != 0)
                {




                }
                else
                {
                    Console.WriteLine("Entrada inválida, insira um número novamente.");
                    Console.ReadLine();
                    continue;
                    
                }
                   

                Console.ReadLine();
            }
            
        }
    }
}
