using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
   public class Exercicio02
    {
        public static void exercicio2()
        {
            Console.WriteLine("EXERCICIO 02 #\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Digite o numero de Linhas e Colunas (Nesta Sequencia) separadas por VIRGULA: ");

            var valoresDigitados = Console.ReadLine();
            var vlMatriz = valoresDigitados.Split(',');
            valoresDigitados = String.Join(",", vlMatriz);
            var linha = Convert.ToInt32(vlMatriz[0]);
            var coluna = Convert.ToInt32(vlMatriz[1]);

            int[,] matriz = new int [linha,coluna];
 
            Console.WriteLine("Digite os valores da Matriz: ");
        
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("["+ i + "]" + "[" + j + "]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("\n");
            }

            Console.WriteLine("Valores na Diagonal Prinicipal");

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}
