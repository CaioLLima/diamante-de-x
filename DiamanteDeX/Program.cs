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
              
                if (entrada % 2 != 0 && entrada >= 1) // não pode ser par e não pode ser menor ou igual a um
                {
                    for (int i = 0; i < entrada; i++)
                    {
                        int numX; // número de X por linha

                        if (i <= entrada / 2)
                        {
                            numX = i * 2 + 1; // Indo de cima para o meio
                        }
                        else
                        {
                            numX = (entrada - i - 1) * 2 + 1; // Indo do  meio para baixo
                        }

                        int espacos = (entrada - numX) / 2;

                        for (int j = 0; j < espacos; j++) //Criando espaços em branco
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < numX; j++)
                        {
                            Console.Write("X"); //imprimindo X baseado no número de linhas
                        }

                        Console.WriteLine(""); // faz separação das linhas
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
