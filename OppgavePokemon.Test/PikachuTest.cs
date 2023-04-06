namespace OppgavePokemon.Test
{
    public class PikachuTest
    {
        [Test]
        public void TestPikachuName()
        {
            var geodude = new Pikachu();

            Assert.That(geodude.Name, Is.EqualTo("Pikachu"));
        }
        [Test]
        public void TestPikachuHealth()
        {
            var geodude = new Pikachu();

            Assert.That(geodude.Health, Is.EqualTo(35));
        }
        [Test]
        public void TestPikachuAttack()
        {
            var attackingPikachu = new Pikachu();
            var defendingPikachu = new Pikachu();

            attackingPikachu.Attack(defendingPikachu);

            Assert.That(defendingPikachu.Health, Is.EqualTo(27));
        }
    }
}