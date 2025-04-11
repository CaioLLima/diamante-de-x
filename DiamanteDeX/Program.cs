using System.Collections;
using System.Threading.Tasks;

namespace DiamanteDeX
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                MostrarCabeçalho();

                int entrada = ObterNumero();

                if (entrada % 2 != 0 && entrada >= 1) 
                {
                    CalculaX(entrada);
                }
                else
                {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    Console.ReadLine();
                }
                Console.ReadLine();
            }   
        }

        static void MostrarCabeçalho()
        {
            Console.Clear();
            Console.WriteLine("Trabalho 01 - Diamante de X");
        }

        static int ObterNumero()
        {
            Console.WriteLine("Insira um número ímpar inteiro: ");
            int entrada;
            while (!int.TryParse(Console.ReadLine(), out entrada))
            {
                Console.WriteLine("Por favor, insira um número válido:");
            }
            return entrada;
        }

        static int CalculaX(int entrada)
        {
            int numX = 0;
            for (int i = 0; i < entrada; i++) 
            {          
                if (i <= entrada / 2)
                {
                    numX = i * 2 + 1; 
                }
                else 
                {
                    numX = (entrada - i - 1) * 2 + 1;
                }
                int espacos = EspacosBrancos(numX, entrada);
                MostrarDesenho(numX, espacos);
            }
            return numX;
        }

        static int EspacosBrancos(int numX, int entrada)
        {
            int espacos = (entrada - numX) / 2;
            return espacos;
        }

        static void MostrarDesenho(int numX, int espacos)
        {
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
}
