using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp3.Exercicio02;

namespace ConsoleApp3
{
    // Deve ser criado uma class chamada pokemon tendo as propriedas ID e nome onde o id pode ser ou numero inteiro ou string aleatoria unica
    // Apos isso deve ser criado uma lista de pokemons onde poderar ser feito ações de adicionar um pokemon, listar 1 pokemon, listar pokemons, editar e remover pokemons.
    //  as açoes devem ser feitas pelo usuario pegando os dados do console sendo elas criar, listar, buscar por id, editar, remover
    public class Exercicio02
    {
        public static void Executar()
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            Pokemon pokemon = new Pokemon();
            Random randNum = new Random();

            string sair = string.Empty;

            do
            {
                Console.WriteLine("* Seja bem vindo ao sistema pokedex *");
                Console.WriteLine("- Escolha uma ação a baixo para continuar - ");

                Console.WriteLine("1. Criar pokemon");
                Console.WriteLine("2. Ver lista de pokemons");
                Console.WriteLine("3. Editar pokemon");
                Console.WriteLine("4. remover pokemon");
                Console.WriteLine("5. buscar um pokemon por ID");

                int option = int.Parse(Console.ReadLine());
                //CRIAR
                if (option == 1)
                {
                    Console.WriteLine("Informe um nome para o pokemon");
                    pokemon.Name = Console.ReadLine();

                    pokemon.Id = randNum.Next(1000);

                    pokemons.Add(pokemon);

                    Console.WriteLine("Pokemon criado com sucesso! Deseja voltar ao menu? S/N");
                    sair = Console.ReadLine().ToUpper();

                }
                // VER LISTA
                else if (option == 2)
                {

                    foreach (Pokemon item in pokemons)
                    {
                        Console.WriteLine(pokemon);
                    }

                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    sair = Console.ReadLine().ToUpper();

                } 
                // EDITAR
                else if(option == 3)
                {
                    Console.WriteLine("Informe o ID do pokemon que deseja editar: ");
                    int idPokemonEditar = int.Parse(Console.ReadLine());

                    foreach(Pokemon item in pokemons)
                    {
                        if(pokemon.Id == idPokemonEditar)
                        {
                            Console.WriteLine("Informe o novo nome do pokemon: ");
                            pokemon.Name = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("Pokemon editado com sucesso! Deseja voltar ao menu? S/N");
                    sair = Console.ReadLine().ToUpper();
                }
                // REMOVER
                else if(option == 4)
                {
                    Console.WriteLine("Informe o ID do pokemon que deseja remover: ");
                    int idPokemonRemover = int.Parse(Console.ReadLine());

                    foreach (Pokemon item in pokemons)
                    {
                        if (pokemon.Id == idPokemonRemover)
                        {
                            pokemons.Remove(pokemon);
                        }
                    }

                    Console.WriteLine("Pokemon removido com sucesso! Deseja voltar ao menu? S/N");
                    sair = Console.ReadLine().ToUpper();
                }

            } while (sair == "S");

        }
        
        public class Pokemon
        {
            public int Id;
            public string Name;

            public override string ToString()
            {
                return $"{this.Id} {this.Name}";
            }

        }


    }
}
