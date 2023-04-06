namespace OppgavePokemon
{
    /*
        Task:
        Create an interface called IPokemon that has a property Health, a method Attack()
        and a method LooseHealth()
        Create a class Magikarp that has a property IsUseless and a method called Splash.
        Create another Class with your favorite pokemon, and methods named the same as the
        attack types of the pokemon you have chosen. In the attack methods, you must enter
        an IPokemon as a parameter and call it its LooseHealth method. 
        Magikarp and your favorite pokemon class must both inherit from IPokemon and both
        must have their own constructor that sets health. 
        Create a few more more different Pokemen and put them all in a list 
        List<IPokemon>wildPokemon in program.cs
        Create a method that returns an IPokemon called GetWildPokemon() that selects and
        returns a random pokemon from the wildPokemon list.
        Define a while loop that retrieves a wild pokemon and lets it battle Magikarp until
        Magikarp has 0 health
     */
    public class Program
    {
        static void Main(string[] args)
        {
            var magikarp = new Magikarp();
            var wildPokemon = new List<IPokemon>()
            {
                new Bulbosaur(),
                new Geodude(),
                new Pikachu()
            };

            var isMagikarpsTurn = true;

            while (true)
            {
                var pokemon = GetWildPokemon(wildPokemon);

                if (isMagikarpsTurn)
                {
                    magikarp.Attack(pokemon);
                    Console.WriteLine($"{magikarp.Name} attacked {pokemon.Name}, {pokemon.Name}'s health is now {pokemon.Health} ");
                }
                else
                {
                    pokemon.Attack(pokemon);
                    Console.WriteLine($"{pokemon.Name} attacked {magikarp.Name}, {magikarp.Name}'s health is now {magikarp.Health} ");
                }

                if (magikarp.Health == 0 || pokemon.Health == 0)
                {
                    ShowWinner(magikarp, pokemon);
                    break;
                }
                isMagikarpsTurn = !isMagikarpsTurn;
            }
        }
        private static void ShowWinner(Magikarp magikarp, IPokemon pokemon)
        {
            if (magikarp.Health == 0) Console.WriteLine("Magikarp won the battle");

            else Console.WriteLine($"{pokemon.Name} won");
        }

        public static IPokemon GetWildPokemon(List<IPokemon> wildPokemon)
        {
            var rand = new Random();
            var index = rand.Next(wildPokemon.Count);
            
            return wildPokemon[index];
        }
    }
}