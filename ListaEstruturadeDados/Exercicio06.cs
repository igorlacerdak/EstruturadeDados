using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
    public class Exercicio06
    {
        public static void exercicio6()
        {
            Console.WriteLine("EXERCICIO 06 #\r");
            Console.WriteLine("------------------------\n");

            int[] valores = { 10, 5, 6, 9, 4, 2, 1, 3, 7, 8};

            Console.Write("VALORES INSERIDOS: ");

            foreach (int numeros in valores)
            {
                Console.Write(String.Format("{0}, ", Convert.ToString(numeros)));
            }

            
            Console.WriteLine("\nQuickSort");

            QuickSort_Recursivo(valores, 0, valores.Length - 1);

            for (int i = 0; i < 10; i++)
                Console.WriteLine(valores[i]);

            Console.ReadLine();

            void QuickSort_Recursivo(int[] vetor, int primeiro, int ultimo)
            {
                int baixo, alto, meio, pivo, repositorio;
                baixo = primeiro;
                alto = ultimo;
                meio = (int)((baixo + alto) / 2);

                pivo = vetor[meio];

                while (baixo <= alto)
                {
                    while (vetor[baixo] < pivo)
                        baixo++;
                    while (vetor[alto] > pivo)
                        alto--;


                    if (baixo < alto)
                    {
                        repositorio = vetor[baixo];
                        vetor[baixo++] = vetor[alto];
                        vetor[alto--] = repositorio;
                    }
                    else
                    {
                        if (baixo == alto)
                        {
                            baixo++;
                            baixo++;
                            alto--;
                        }
                    }
                }

                if (alto > primeiro)
                    QuickSort_Recursivo(vetor, primeiro, alto);
                if (baixo < ultimo)
                    QuickSort_Recursivo(vetor, baixo, ultimo);
            }

        }
    }
}
