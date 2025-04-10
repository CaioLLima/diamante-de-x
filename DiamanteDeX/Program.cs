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
                            diamante[j] = "_";
                            diamante[entrada / 2] = "X";


                            // diamante[0] = "O";
                            if (diamante[i] == diamante[2])
                            {
                                diamante[j] = diamante[i];
                                //Console.Write(diamante[i]);
                            }
                            

                            //diamante[entrada - 1] = "X";
                            Console.Write(diamante[j]);
                            
                        }
                        diamante[i] = "C";
                        diamante[entrada / 2] = "X";
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
