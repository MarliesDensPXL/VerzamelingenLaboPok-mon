namespace LaboPokémon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pokémon = new string[4];
            pokémon[0] = "Pikachu";
            pokémon[1] = "Bulbasaur";
            pokémon[2] = "Charmander";
            pokémon[3] = "Squirtle";

            Console.WriteLine(pokémon[0]);

            Array.Clear(pokémon, 1, 1);

            PrintPokemonRoster(pokémon);

            Console.WriteLine();

            bool isValid = IsValidPokemonRosterSize(pokémon);
            Console.WriteLine(isValid);

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

        static void PrintPokemonRoster(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        static bool IsValidPokemonRosterSize(string[] names)
        {
            if (names.Length == 6)
                return true;
            else
                return false;
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
