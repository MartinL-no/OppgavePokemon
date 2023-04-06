namespace OppgavePokemon.Test
{
    public class MagiikarpTest
    {
        [Test]
        public void TestMagikarpName()
        {
            var geodude = new Magikarp();

            Assert.That(geodude.Name, Is.EqualTo("Magikarp"));
        }
        [Test]
        public void TestMagikarpHealth()
        {
            var magikarp = new Magikarp();

            Assert.That(magikarp.Health, Is.EqualTo(30));
        }
        [Test]
        public void TestMagikarpIsUseless()
        {
            var magikarp = new Magikarp();

            Assert.That(magikarp.IsUseless, Is.EqualTo(true));
        }
        [Test]
        public void TestMagikarpAttack()
        {
            var attackingMagikarp = new Magikarp();
            var defendingMagikarp = new Magikarp();

            attackingMagikarp.Splash(defendingMagikarp);

            Assert.That(defendingMagikarp.Health, Is.EqualTo(25));
        }
    }
}