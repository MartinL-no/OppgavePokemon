using System;

namespace OppgavePokemon
{
    public class Geodude: IPokemon
    {
        public int Health { get; private set; }
        public string Name { get; }


        public Geodude()
        {
            Name = "Geodude";
            Health = 40;
        }
        public void Attack(IPokemon pokemon)
        {
            RockThrow(pokemon);
        }

        public void LooseHealth(int lostHealth)
        {
            Health = Health- lostHealth < 0 ? 0 : Health- lostHealth;
        }

        public void RockThrow(IPokemon pokemon)
        {
            pokemon.LooseHealth(10);
        }
    }
}