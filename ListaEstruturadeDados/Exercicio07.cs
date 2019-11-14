using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturadeDados
{
    public class Exercicio07
    {
        public static void exercicio7()
        {
            Console.WriteLine("EXERCICIO 07");
            Console.WriteLine("-----------\n");

            Console.Write("INFORME A QUANTIDADE DE PERSONAGENS: ");

                int qtde = int.Parse(Console.ReadLine());

            Personagem[] listaP = new Personagem[qtde];
            Personagem p;

            for (int i = 0; i < listaP.Length; i++)
            {
                Console.Write("DIGITE O NOME "+ (i + 1)+"°" + " DO PERSONAGEM:");
                p = new Personagem();
                p.nome = (Console.ReadLine());
                p.codigo = i + 1;
                listaP[i] = p;
            }

            foreach (Personagem x in listaP)
            {
                Console.WriteLine(x.codigo + " - " + x.nome);
            }
        }
    }
}
