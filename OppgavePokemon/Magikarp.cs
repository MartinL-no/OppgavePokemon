using System;

namespace OppgavePokemon
{
    public class Magikarp : IPokemon
    {
        public int Health { get; private set; }
        public string Name { get; }

        public readonly bool IsUseless;

        public Magikarp()
        {
            Name = "Magikarp";
            Health = 30;
            IsUseless = true;
        }
        public void Attack(IPokemon pokemon)
        {
            Splash(pokemon);
        }

        public void LooseHealth(int lostHealth)
        {
            Health = Health- lostHealth < 0 ? 0 : Health- lostHealth;
        }

        public void Splash(IPokemon pokemon)
        {
            pokemon.LooseHealth(5);
        }
    }
}
