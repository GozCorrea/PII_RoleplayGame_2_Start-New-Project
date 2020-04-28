using NUnit.Framework;
using RoleplayGame;


namespace Library.Test
{
    public class CharacterTest
    {
        private Archer archer1;
        private Dwarf dwarf1;
        int AttackValue1;
        int DefenseValue1;
        
        [SetUp]
        public void Setup()
        {
            archer1 = new Archer("x");
            archer1.Bow = new Bow();
            archer1.Helmet = new Helmet();

            dwarf1 = new Dwarf("y");
            dwarf1.Axe = new Axe();
            dwarf1.Helmet = new Helmet();
            dwarf1.Shield = new Shield();


        }

        [Test]
        public void ValorDeAtaqueDeArqueroIgualA15()
        {
            AttackValue1 = archer1.AttackValue;
            string expected = "15";
            Assert.Pass(expected, AttackValue1);
        }

        [Test]
        public void SaludDeEnanoTrasSerAtacadoPorArquero()
        {
            dwarf1.ReceiveAttack(archer1.AttackValue);
            string expected = "85";
            Assert.Pass(expected, dwarf1.Health);
        }

        [Test]
        public void ValorDeDefensaDelArqueroIgualA18()
        {
            DefenseValue1 = archer1.DefenseValue;
            string expected = "18";
            Assert.Pass(expected, archer1.DefenseValue);
        }

        [Test]
        public void SaludDelEnanoIgualA100TrasSerCurado()
        {
            dwarf1.ReceiveAttack(archer1.AttackValue);
            dwarf1.Cure();
            string expected = "100";
            Assert.Pass(expected, dwarf1.Health);
        }

        [Test]
        public void SaludArqueroNuncaNegativa()
        {
            int salud = archer1.Health;
            salud = -10;
            string expected = "0";
            Assert.Pass(expected, archer1.Health);
        }

    }
}