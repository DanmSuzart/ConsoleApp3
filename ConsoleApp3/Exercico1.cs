using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Exercico1
    {
        public static void Executar()
        {
            List<String> listFruit = new List<String>();

            string sair = string.Empty;

            do
            {
                Console.WriteLine("Informe uma fruta: ");
                string fruitName = Console.ReadLine();

                listFruit.Add(fruitName);

                Console.WriteLine("Deseja continuar? S/N");
                sair = Console.ReadLine().ToUpper();


            } while (sair != "N");


            foreach (string fruit in listFruit)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
