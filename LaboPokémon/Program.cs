namespace LaboPokémon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.2
            string[] pokémon = new string[6];

            //1.3

            pokémon[0] = "Pikachu";
            pokémon[1] = "Bulbasaur";
            pokémon[2] = "Charmander";
            pokémon[3] = "Squirtle";

            //1.4
            Console.WriteLine(pokémon[0]);

            //1.5
           // pokémon[2] = ""; maakt de string leeg
            // pokémon[2] = string.Empty; maakt de string ook leeg. Doet exact hetzelfde als regel hierboven.

           Array.Clear(pokémon, 2, 1); // doet óók exact hetzelfde maar dan via de meest aangewezen manier. Werkt voor álle types van arrays. de vorige twee manieren werken enkel voor een string-array.
            // je geeft eerst de array, dan welke positie je wil leegmaken, en dan het aantal elementen dat je wil leegmaken (in de geval maar 1) 

            
            //1.6
            PrintPokemonRoster(pokémon);

            Console.WriteLine();

            //1.7

            bool isValid = IsValidPokemonRosterSize(pokémon);
            Console.WriteLine($"Geldige lengte: {(isValid ? "ja" : "nee")}");

            //1.8
            // 3 manieren om een nieuwe array aan te maken en te initialiseren.
            //string[] pokemons2= new string[6] {"", "", "", "", "", ""};
            //string[] pokemons2 = { "", "", "", "", "", "", "" };
            string[] pokemons2 = ["Pikachu", "Charmander", "Squirtle", "", "", ""];
            PrintPokemonRoster(pokemons2);

            Pokemon charmeleon = new Pokemon("Charmeleon", "Fire");
            Pokemon raichu = new Pokemon();
            raichu.Name = "Raichu";
            raichu.Type = "Electric";
            Pokemon golem = new Pokemon();
            golem.Name = "Golem";
            golem.Type = "Rock";
            Pokemon eevee = new Pokemon();
            eevee.Name = "Eevee";
            eevee.Type = "Normal";        
            Pokemon bonsly = new Pokemon("Bonsly", "Rock");            
            Pokemon treecko = new Pokemon("Treecko", "Grass");

            Pokemon[] pokémon1 = new Pokemon[] {charmeleon, raichu, golem, eevee, bonsly, treecko};
            Pokemon[] pokémon2 = new Pokemon[] { raichu, golem, eevee, bonsly, treecko, charmeleon };

            Trainer trainer1 = new Trainer();
            trainer1.Pokemon = pokémon1;
            
            Trainer trainer2 = new Trainer();
            trainer2.Pokemon = pokémon2;

            Console.WriteLine(trainer1.Pokemon);
            Console.WriteLine(trainer2.Pokemon);

            TradeFirstPokemon(trainer1, trainer2);

            Console.WriteLine(trainer1.Pokemon);
            Console.WriteLine(trainer2.Pokemon);


        }

        static void PrintPokemonRoster(string[] names) //1.6
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i+1}: {names[i]}");
            }
        }

        static bool IsValidPokemonRosterSize(string[] names) //1.7
        {
            //if (names.Length == 6)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return names.Length == 6; // is een veel kortere manier om een true terug te geven. In de code hierboven controleer je true or false voor een bool die sowieso true or false controleert.
        }

        static void TradeFirstPokemon(Trainer trainer1, Trainer trainer2) // GEKNOEI 
        {
            // Array.Clear(trainer1.Pokemon, 0, 0);
            // trainer1.Pokemon[0] = trainer2.Pokemon[0];

        

            
            //Pokemon[] tradedPokémon1 = new Pokemon[] { trainer1.Pokemon[0], trainer2.Pokemon[1], trainer2.Pokemon[2], trainer2.Pokemon[3], trainer2.Pokemon[4], trainer2.Pokemon[5] };
            //Pokemon[] tradedPokémon2 = new Pokemon[] { trainer2.Pokemon[0], trainer1.Pokemon[1], trainer1.Pokemon[2], trainer1.Pokemon[3], trainer1.Pokemon[4], trainer1.Pokemon[5] };

            //trainer2.Pokemon = {trainer1.Pokemon[0], trainer2.Pokemon[1], trainer2.Pokemon[2], trainer2.Pokemon[3], trainer2.Pokemon[4], trainer2.Pokemon[5] };
            //Pokemon[] tradedPokémon2 = new Pokemon[] { trainer2.Pokemon[0], trainer1.Pokemon[1], trainer1.Pokemon[2], trainer1.Pokemon[3], trainer1.Pokemon[4], trainer1.Pokemon[5] };

            // string firstPokemon = trainer1.Pokemon[0].ToString();
        }
    }
}
