using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
    public class Exercicio08
    {
        public static void exercicio8()
        {
            List<string> lista = new List<string>();

            Personagem p = new Personagem();
            string opcao = "1";

            while (opcao == "1")
            {
                Console.WriteLine("Digite um nome para inserir na lista:");
                string nome = Console.ReadLine();
                //Adiciona o item à lista
                lista.Add(p.nome);
                Console.WriteLine("Deseja inserir outro nome? 1-SIM | 2-NÃO");
                opcao = Console.ReadLine();
            }
            //Ordena a lista 
            lista.Sort();
            Console.WriteLine("A lista tem " + lista.Count + " itens:");
            //Imprime cada item da lista
            lista.ForEach(personagem  => Console.WriteLine(Convert.ToString(p.nome)));;

        }
    }
}
