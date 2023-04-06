namespace OppgavePokemon.Test
{
    public class ProgramTest
    {
        [Test]
        public void TestGetWildPokemon()
        {
            var wildPokemon = new List<IPokemon>()
            {
                new Bulbosaur(),
                new Geodude(),
                new Pikachu()
            };
            var pokemon = Program.GetWildPokemon(wildPokemon);

            Assert.That(pokemon, Is.InstanceOf(typeof(IPokemon)));
            Assert.That(pokemon, Is.AnyOf(wildPokemon[0], wildPokemon[1], wildPokemon[2]));
        }
    }
}