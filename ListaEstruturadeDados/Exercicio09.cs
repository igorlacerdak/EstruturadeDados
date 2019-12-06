using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
    public class Exercicio09
    {
        public static void exercicio9()
        {
            int[] vetor = new int[5];
            // ARAXA = 0
            // TAPIRA = 1
            // CAMPOS ALTOS = 2
            // IBIA = 3
            // PERDIZES = 4

            int[,] cidades = new int[5, 5];
            // ARAXA
            cidades[0, 0] = 0;  // Araxa para Araxa
            cidades[0, 1] = 40;  // Araxa para Tapira
            cidades[0, 2] = 100; // Araxa para Campos Altos
            cidades[0, 3] = 70;  // Araxa para Ibia
            cidades[0, 4] = 45;  // Araxa para Perdizes
            // TAPIRA
            cidades[1, 0] = 40; // Tapira para Araxa
            cidades[1, 1] = 0; // Tapira para Tapira
            cidades[1, 2] = 0; // Tapira para Campos Altos
            cidades[1, 3] = 0; // Tapira para Ibia
            cidades[1, 4] = 0; // Tapira para Perdizes
            // CAMPOS ALTOS
            cidades[2, 0] = 100; // Campos Altos para Araxa
            cidades[2, 1] = 0; // Campos Altos para Tapira
            cidades[2, 2] = 0; // Campos Altos para Campos Altos
            cidades[2, 3] = 30; //Campos Altos para Ibia
            cidades[2, 4] = 0; // Campos Altos para Perdizes
            // IBIA
            cidades[3, 0] = 70; // Ibia para Araxa
            cidades[3, 1] = 0; //  Ibia para Tapira
            cidades[3, 2] = 30; // Ibia para Campos Altos
            cidades[3, 3] = 0; // Ibia para Ibia
            cidades[3, 4] = 100; //  Ibia para Perdizes
            // PERDIZES    
            cidades[4, 0] = 45;   //  Perdizes para Araxa
            cidades[4, 1] = 0;    //  Perdizes para Tapira
            cidades[4, 2] = 0;    //  Perdizes para Campos Altos
            cidades[4, 3] = 100;  //  Perdizes para Ibia
            cidades[4, 4] = 0;    //  Perdizes para Perdizes

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (cidades[i, j] > 0)
                    {
                        vetor[i]++;
                    }
                }

                Console.WriteLine("Quantidade de Ligacoes: {0}", vetor[i]);

            }


        }
    }
}