using NUnit.Framework;
using RoleplayGame;


namespace Library.Test
{
    public class KnightTest
    {
        private Knight knight1;
        private Archer archer1;
        int AttackValue1;
        int DefenseValue1;
        
        [SetUp]
        public void Setup()
        {
            knight1 = new Knight("X");
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();
            
            archer1 = new Archer("x");
            archer1.Bow = new Bow();
            archer1.Helmet = new Helmet();
        }

        [Test]
        public void ValorDeAtaqueDeCaballeroIgualA20()
        {
            AttackValue1 = knight1.AttackValue;
            string expected = "20";
            Assert.Pass(expected, AttackValue1);
        }

        [Test]
        public void SaludDeArqueroTrasSerAtacadoPorCaballero()
        {
            archer1.ReceiveAttack(knight1.AttackValue);
            string expected = "80";
            Assert.Pass(expected, archer1.Health);
        }

        [Test]
        public void ValorDeDefensaDelCaballeroIgualA18()
        {
            DefenseValue1 = knight1.DefenseValue;
            string expected = "39";
            Assert.Pass(expected, DefenseValue1);
        }

        [Test]
        public void SaludDelCaballeroIgualA100TrasSerCurado()
        {
            knight1.ReceiveAttack(archer1.AttackValue);
            knight1.Cure();
            string expected = "100";
            Assert.Pass(expected, knight1.Health);
        }

        [Test]
        public void SaludCaballeroNuncaNegativa()
        {
            int salud = knight1.Health;
            salud = -10;
            string expected = "0";
            Assert.Pass(expected, knight1.Health);
        }

    }
}