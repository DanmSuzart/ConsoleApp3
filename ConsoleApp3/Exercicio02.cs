using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static ConsoleApp3.Exercicio02;

namespace ConsoleApp3
{
    // Deve ser criado uma class chamada pokemon tendo as propriedas ID e nome onde o id pode ser ou numero inteiro ou string aleatoria unica
    // Apos isso deve ser criado uma lista de pokemons onde poderar ser feito ações de adicionar um pokemon, listar 1 pokemon, listar pokemons, editar e remover pokemons.
    //  as açoes devem ser feitas pelo usuario pegando os dados do console sendo elas criar, listar, buscar por id, editar, remover
    public class Exercicio02
    {
        public static bool CriacaoPokemon(List<Pokemon> pokemons)
        {

            Random randNum = new Random();
            Pokemon pokemon = new Pokemon();

            Console.WriteLine("Informe um nome para o pokemon");
            string name = Console.ReadLine();

            var nameAlreadyInUse = pokemons.FirstOrDefault(pokemon => pokemon.Name.Contains(name));

            if (nameAlreadyInUse is not null)
            {
                Console.WriteLine("Pokemon já existe. Voltando ao menu...");
                return false;
            }
            pokemon.Name = name;
            pokemon.Id = randNum.Next(1000);
            pokemons.Add(pokemon);
            return true;
            
        }

        public static void ListarPokemon(List<Pokemon> pokemons)
        {
            foreach (Pokemon pokemon in pokemons)
            {
                Console.WriteLine(pokemon);
            }

        }

        public static bool EditarPokemon(List<Pokemon> pokemons)
        {
            Console.WriteLine("Informe o ID do pokemon que deseja editar: ");
            int idPokemonEditar = int.Parse(Console.ReadLine());

            var pokemonExist = pokemons.FirstOrDefault(pokemon => pokemon.Id == idPokemonEditar);

            if (pokemonExist is null)
            {
                Console.WriteLine("Pokemon não encontrado. Voltando ao menu");
                return false;
            }

            Console.WriteLine("Informe o novo nome do pokemon");
            string pokemonName = Console.ReadLine();

            var nameAlreadyInUse = pokemons.FirstOrDefault(pokemon => pokemon.Name.Contains(pokemonName));

            if (nameAlreadyInUse is null)
            {
                pokemonExist.Name = pokemonName;
                return true;
            }
            else
            {
                Console.WriteLine("Nome do pokemon já existe. Voltando ao menu");
                return false;
            }

        }

        public static bool RemoverPokemon(List<Pokemon> pokemons)
        {
            Console.WriteLine("Informe o ID do pokemon que deseja remover: ");
            int idPokemonRemover = int.Parse(Console.ReadLine());

            var pokemonExist = pokemons.FirstOrDefault(pokemon => pokemon.Id == idPokemonRemover);

            if (pokemonExist is null)
            {
                Console.WriteLine("Pokemon não encontrado. Voltando ao menu");
                return false;
            }

            pokemons.Remove(pokemonExist);
            return true;
          
        }


        public static bool BuscarPokemon(List<Pokemon> pokemons)
        {
            Console.WriteLine("Informe o nome do pokemon que deseja procurar: ");
            string pokemonBuscado = Console.ReadLine();

            var pokemonExist = pokemons.FirstOrDefault(pokemon => pokemon.Name.Contains(pokemonBuscado));

            if(pokemonExist is null)
            {
                Console.WriteLine("Pokemon não encontrado. Voltando ao menu");
                return false;
            }

            Console.WriteLine(pokemonExist);
            return true;

        }
            
           
        




        public static void Executar()
        {
            List<Pokemon> pokemons = new List<Pokemon>();


            string sair = string.Empty;

            do
            {
               

                Console.WriteLine("* Seja bem vindo ao sistema pokedex *");
                Console.WriteLine("- Escolha uma ação a baixo para continuar - ");

                Console.WriteLine("1. Criar pokemon");
                Console.WriteLine("2. Ver lista de pokemons");
                Console.WriteLine("3. Editar pokemon");
                Console.WriteLine("4. remover pokemon");
                Console.WriteLine("5. buscar um pokemon por nome");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                   bool isCreateSuccess = CriacaoPokemon(pokemons);
                   if(isCreateSuccess == false)
                    {
                        continue;
                    }

                    Console.WriteLine("Pokemon criado com sucesso! Deseja voltar ao menu? S/N");
                    sair = Console.ReadLine().ToUpper();

                }

                else if (option == 2)
                {
                    ListarPokemon(pokemons);
                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    sair = Console.ReadLine().ToUpper();

                } 
              
                else if(option == 3)
                {
                   
                   bool isEditSuccess = EditarPokemon(pokemons);
                    if(isEditSuccess == false)
                    {
                        continue;
                    }

                    Console.WriteLine("Pokemon editado com sucesso. Deseja voltar ao menu? S/N");
                    sair = Console.ReadLine().ToUpper();


                }
                
                else if(option == 4)
                {
                    bool isCreateSuccess =  RemoverPokemon(pokemons);

                    if (isCreateSuccess == false)
                    {
                        continue;
                    }

                    Console.WriteLine("Pokemon removido com sucesso. Dseja voltar ao menu? S/N");
                    sair = Console.ReadLine().ToUpper();
                }
                else if (option == 5)
                {
                    bool isCreateSuccess = BuscarPokemon(pokemons);

                    if(isCreateSuccess == false)
                    {
                        continue;
                    }

                    Console.WriteLine("Deseja voltar ao menu? S/N");
                    sair = Console.ReadLine().ToUpper();

                } else
                {
                    Console.WriteLine("Opção invalida. voltando ao menu");
                    sair = "S";
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
