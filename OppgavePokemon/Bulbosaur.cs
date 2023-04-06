using System;

namespace OppgavePokemon
{
    public class Bulbosaur: IPokemon
    {
        public int Health { get; private set; }
        public string Name { get; }

        public Bulbosaur()
        {
            Health = 32;
            Name = "Bulbosaur";
        }
        public void Attack(IPokemon pokemon)
        {
            VineWhip(pokemon);
        }

        public void LooseHealth(int lostHealth)
        {
            Health = Health- lostHealth < 0 ? 0 : Health- lostHealth;
        }

        public void VineWhip(IPokemon pokemon)
        {
            pokemon.LooseHealth(6);
        }
    }
}