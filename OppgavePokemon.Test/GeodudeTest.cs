namespace OppgavePokemon.Test
{
    public class GeodudeTest
    {
        [Test]
        public void TestGeodudeName()
        {
            var geodude = new Geodude();

            Assert.That(geodude.Name, Is.EqualTo("Geodude"));
        }
        [Test]
        public void TestGeodudeHealth()
        {
            var geodude = new Geodude();

            Assert.That(geodude.Health, Is.EqualTo(40));
        }
        [Test]
        public void TestGeodudeAttack()
        {
            var attackingGeodude = new Geodude();
            var defendingGeodude = new Geodude();

            attackingGeodude.Attack(defendingGeodude);

            Assert.That(defendingGeodude.Health, Is.EqualTo(30));
        }
    }
}