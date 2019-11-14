
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
    public class Exercicio04
    {
        public static void exercicio4()
        {
            Console.WriteLine("EXERCICIO 04 #\r");
            Console.WriteLine("------------------------\n");

            Stack<int> valores = new Stack<int>();

            valores.Push(10);
            valores.Push(20);
            valores.Push(30);
            valores.Push(40);
            valores.Push(50);
            valores.Push(60);

            Console.WriteLine("\nListando informações na Lista");

            foreach (int numeros in valores)
            {
                Console.WriteLine(numeros);
            }
            Console.WriteLine("Quantidade de elementos de " + valores.Count.ToString() + " na lista.");

            Console.WriteLine("\nUtilizando estrutura POP na Lista");

            while (valores.Count > 0)
            {
                Console.WriteLine(valores.Pop());

            }

            Console.WriteLine("A lista possui agora " + valores.Count.ToString() + " elementos.");
            Console.Read();
        }
    }
}