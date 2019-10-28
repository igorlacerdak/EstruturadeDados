using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
    public class Exercicio01
    {

        public static void exercicio1()
        {
            Console.WriteLine("EXERCICIO 01 #\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Digite os valores desejados separados por VIRGULA, e pressione enter: ");

            var valoresDigitados = Console.ReadLine();
            var vlVetor = valoresDigitados.Split(',');
            valoresDigitados = String.Join(",", vlVetor);

            Console.WriteLine("------------------------\n");
            Console.WriteLine("Digite o valor para pesquisar no vetor: ");
            var pesquisaValor = Console.ReadLine();

            var resultado = false;

            for (int i = 0; i < vlVetor.Length; i++)
            {
                if (pesquisaValor == vlVetor[i])
                {
                    Console.WriteLine("Sim, ele existe na posição: " + (i + 1));
                    resultado = true;
                }
            }

            if (resultado == false)
            {
                Console.WriteLine("Não, ele não existe");
            }
        }
    }
}