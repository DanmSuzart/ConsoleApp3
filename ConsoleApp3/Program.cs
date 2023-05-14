using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Exercicio
    {
       public static void Main(string[] args)
        {
           List<String> listName = new List<String>();

            int cont = 1;

            for (int i = 0; i < cont; i++) 
            { 
                Console.WriteLine("Informe um nome: ");

                listName.Add(Console.ReadLine());

                Console.WriteLine("Deseja sair? S/N");

                string sair = Console.ReadLine();

                if(sair == "S")
                {
                    cont = cont - 1;
                } else
                {
                    cont = cont + 1;
                }

            }

            foreach(string name in  listName)
            {
                Console.WriteLine(name);
            }
        }
    }
}
