using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
    class Program
    {

        static void Main(string[] args)
        {
            EscolheExercicio();
        }

        static protected void EscolheExercicio()
        {
            // Ask the user to choose an option.
            Console.WriteLine("Escolha o Exercicio Desejado:");
            Console.WriteLine("\tExercicio - 1");
            Console.WriteLine("\tExercicio - 2");
            Console.WriteLine("\tExercicio - 3");
            Console.WriteLine("\tExercicio - 4");
            Console.WriteLine("\tExercicio - 5");
            Console.WriteLine("\tExercicio - 6");
            Console.WriteLine("\tExercicio - 7");
            Console.WriteLine("\tExercicio - 8");
            Console.WriteLine("\tExercicio - 9");
            Console.WriteLine("\tExercicio - 10");
            Console.WriteLine("\tExercicio - 11");
            Console.Write("Qual exercicio? ");



            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "1":
                    Exercicio01.exercicio1();
                    break;
                case "2":
                    Exercicio02.exercicio2();
                    break;
                case "3":
                    Exercicio03.exercicio3();
                    break;
                case "4":
                    Exercicio04.exercicio4();
                    break;
                case "5":
                    Exercicio05.exercicio5();
                    break;
                case "6":
                    Exercicio06.exercicio6();
                    break;
                case "7":
                    Exercicio07.exercicio7();
                    break;
                case "8":
                    Exercicio08.exercicio8();
                    break;
                case "9":
                    Exercicio09.exercicio9();
                    break;
                case "10":
                    Exercicio10.exercicio10();
                    break;
                case "11":
                    Exercicio11.exercicio11();
                    break;
            }


            // Wait for the user to respond before closing.
            Console.WriteLine("Deseja buscar outro exercício? (S) Sim / (N) Não");
            string buscarNovamente = Console.ReadLine();

            while (buscarNovamente.Equals("S"))
            {
                EscolheExercicio();
            }

            Console.Write("Pressione qualquer tecla para sair...");
            Environment.Exit(0);
        }
    }
}