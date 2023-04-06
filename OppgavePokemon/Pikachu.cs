using System;

namespace OppgavePokemon
{
    public class Pikachu: IPokemon
    {
        public int Health { get; private set; }
        public string Name { get; }


        public Pikachu()
        {
            Name = "Pikachu";
            Health = 35;
        }
        public void Attack(IPokemon pokemon)
        {
            ThunderShock(pokemon);
        }

        public void LooseHealth(int lostHealth)
        {
            Health = Health- lostHealth < 0 ? 0 : Health- lostHealth;
        }

        public void ThunderShock(IPokemon pokemon)
        {
            pokemon.LooseHealth(8);
        }
    }
}