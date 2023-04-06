namespace OppgavePokemon.Test
{
    public class BulbosaurTest
    {
        [Test]
        public void TestBulbosaurName()
        {
            var geodude = new Bulbosaur();

            Assert.That(geodude.Name, Is.EqualTo("Bulbosaur"));
        }
        [Test]
        public void TestBulbosaurHealth()
        {
            var geodude = new Bulbosaur();

            Assert.That(geodude.Health, Is.EqualTo(32));
        }
        [Test]
        public void TestBulbosaurAttack()
        {
            var attackingBulbosaur = new Bulbosaur();
            var defendingBulbosauru = new Bulbosaur();

            attackingBulbosaur.Attack(defendingBulbosauru);

            Assert.That(defendingBulbosauru.Health, Is.EqualTo(26));
        }
    }
}