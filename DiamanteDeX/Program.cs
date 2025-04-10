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
                string linha1 = "";

                if (entrada % 2 != 0 && entrada > 1)
                {
                    for (int i = 0; i < entrada; i++)
                    {
                        for (int j = 0; j < entrada; j++)
                        {                         
                            diamante[j] = " "; //transforma o 5 x 5 em _

                            diamante[2] = "X"; //está criando os X na vertical principal entrada/2

                            if (i==1)
                            {
                                diamante[entrada/2 -1] = "X";
                                diamante[entrada / 2 + 1] = "X";
                            }
                            if (i == 2)
                            {
                                diamante[entrada / 2 - 1] = "X";
                                diamante[entrada / 2 + 1] = "X";
                                diamante[entrada / 2 - 2] = "X";
                                diamante[entrada / 2 + 2] = "X";
                            }
                            if (i == 3)
                            {
                                diamante[entrada / 2 - 1] = "X";
                                diamante[entrada / 2 + 1] = "X";
                            }
                            



                            //diamante[entrada - 1] = "X";
                            Console.Write(diamante[j]);
                            
                        }
                        diamante[i] = "C";
                       // diamante[entrada / 2] = "X";

                        
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
