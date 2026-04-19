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

            Pokemon[] pokémon2 = new Pokemon[] {charmeleon, raichu, golem, eevee, bonsly, treecko};
            
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
    }
}
