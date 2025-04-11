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
                Console.WriteLine("Insira um número ímpar inteiro: ");
                int entrada = int.Parse(Console.ReadLine());
              
                if (entrada % 2 != 0 && entrada >= 1)
                {
                    for (int i = 0; i < entrada; i++)
                    {
                        int numX;

                        if (i <= entrada / 2)
                        {
                            numX = i * 2 + 1;
                        }
                        else
                        {
                            numX = (entrada - i - 1) * 2 + 1;
                        }

                        int espacos = (entrada - numX) / 2;

                        for (int j = 0; j < espacos; j++) 
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < numX; j++)
                        {
                            Console.Write("X");
                        }

                        Console.WriteLine(""); 
                    }
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
