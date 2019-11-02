using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
    public class Exercicio05
    {

        public static void exercicio5()
        {
            Console.WriteLine("EXERCICIO 05 #\r");
            Console.WriteLine("------------------------\n");

            int[] vetor = { 10, 5, 8, 4, 6, 3, 2, 9, 1, 7 };
            int aux = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        //AQUI OCORRE A TROCA, DO MAIOR PARA DIREITA E O MENOR PARA ESQUERDA;
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }

            }

            Console.WriteLine("\nOrdenando a Lista");
            for (int order = 0; order < vetor.Length; order++)
            {
                Console.WriteLine(vetor[order]);
            }

            Console.WriteLine("Qual posição do valor... ");
            int oVetor = Convert.ToInt32(Console.ReadLine());



            int retorno = Array.BinarySearch(vetor, oVetor);

            if (retorno >= 0)

                Console.WriteLine("Indice do Item " + retorno.ToString());

            else

                Console.WriteLine("Item não localizado");

            Console.ReadKey();
        }

    }
}