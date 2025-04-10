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
                int entrada = 5;//int.Parse(Console.ReadLine());
                string[] diamante = new string[entrada];
                int meio = entrada / 2;
                int esquerda = meio;
                int direita = meio;

                if (entrada % 2 != 0 && entrada > 1)
                {
                    for (int i = 0; i < entrada; i++)
                    {
                        string linha = "";
                        for (int j = 0; j < entrada; j++)
                        {                         
                            if (j == direita || j == esquerda) // cria grande vertical de X
                            {
                                linha += "X";
                            }
                            else
                                linha += "_";
                        }

                        Console.Write(linha);

                        if (i < meio) 
                        {
                            esquerda--;
                            direita++;
                        }
                        else
                        {
                            esquerda++;
                            direita--;
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
