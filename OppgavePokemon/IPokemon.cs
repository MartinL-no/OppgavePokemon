using System;

namespace OppgavePokemon
{
    public interface IPokemon
    {
        int Health { get; }
        string Name { get; }
        void Attack(IPokemon pokemon);
        void LooseHealth(int lostHealth);
    }
}