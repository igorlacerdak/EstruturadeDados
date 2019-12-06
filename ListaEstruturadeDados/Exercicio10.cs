using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
    public class Exercicio10
    {
        static int i, j;
        static int result;
        static int [,] matriz = new int [3,5];

        public static void exercicio10()
        {

            matriz[0, 0] = 0;
            matriz[0, 1] = 1;
            matriz[0, 2] = 0;
            matriz[0, 3] = 1;
            matriz[0, 4] = 1;
            matriz[1, 0] = 1;
            matriz[1, 1] = 0;
            matriz[1, 2] = 1;
            matriz[1, 3] = 0;
            matriz[1, 4] = 1;
            matriz[2, 0] = 0;
            matriz[2, 1] = 1;
            matriz[2, 2] = 1;
            matriz[2, 3] = 1;
            matriz[2, 4] = 0;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (matriz[i,j] == 1)
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine("A plantacao apresenta " + result + " falhas");

        }


    }
}
