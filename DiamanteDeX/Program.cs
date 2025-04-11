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
                //cabeçalho
                MostrarCabeçalho();

                //obter numero
                int entrada = ObterNumero();


                //processamento
                if (entrada % 2 != 0 && entrada >= 1) // não pode ser par e não pode ser menor ou igual a um
                {
                    //gera linhas
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
            int entrada = 5;// int.Parse(Console.ReadLine());
            return entrada;
        }

        static int CalculaX(int entrada)
        {
            int numX = 0; // número de X por linha
            for (int i = 0; i < entrada; i++)  //loop principal para gerar linhas
            {          
                //calculo desenho
                if (i <= entrada / 2) //se a linha for menor que a metade do diamante
                {
                    numX = i * 2 + 1; // calculo de quantos X vai ter na linha
                }
                else //se a linha for maior que a metade do diamante
                {
                    numX = (entrada - i - 1) * 2 + 1; // Indo do  meio para baixo
                }
                //calcula espaços
                int espacos = EspacosBrancos(numX, entrada);
                MostrarDesenho(numX, espacos);
            }
            return numX;
        }

        static int EspacosBrancos(int numX, int entrada)
        {
            int espacos = (entrada - numX) / 2; //calculo saber quantos espaços em branco  vai ter
            return espacos;
        }

        static void MostrarDesenho(int numX, int espacos)
        {
            //mostrar desenho
            for (int j = 0; j < espacos; j++) //Criando espaços em branco
            {
                Console.Write(" ");
            }

            for (int j = 0; j < numX; j++)
            {
                Console.Write("X"); //imprimindo X baseado no número de X que vai ter na linha
            }

            Console.WriteLine(""); // faz separação das linhas
        }
    }
}
