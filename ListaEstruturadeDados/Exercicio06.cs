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
            int[] valores = { 5, 9, 10, 11, 4, 3, 7, 8, 1, 2 };
            Console.WriteLine("QuickSort");

            QuickSort_Recursivo(valores, 0, valores.Length - 1);

            for (int i = 0; i < 10; i++)
                Console.WriteLine(valores[i]);

            Console.ReadLine();
        }

        static public void QuickSort_Recursivo(int[] valores, int primeiro, int ultimo)
        {
            int baixo, alto, meio, pivo, repositorio;
            baixo = primeiro;
            alto = ultimo;
            meio = (int)((baixo + alto) / 2);

            pivo = valores[meio];

            while (baixo <= alto)
            {
                while (valores[baixo] < pivo)
                    baixo++;
                while (valores[alto] > pivo)
                    alto--;
            }

            if (baixo < alto)
            {
                repositorio = valores[baixo];
                valores[baixo++] = valores[alto];
                valores[alto--] = repositorio;
            }
            else
            {
                if (baixo == alto)
                {
                    baixo++;
                    alto--;
                }
            }

            if (alto > primeiro)
                QuickSort_Recursivo(valores, primeiro, alto);
            if (baixo < ultimo)
                QuickSort_Recursivo(valores, baixo, ultimo);
            }


    }
} 

