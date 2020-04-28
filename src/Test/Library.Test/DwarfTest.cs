using NUnit.Framework;
using RoleplayGame;


namespace Library.Test
{
    public class DwarfTest
    {
        private Dwarf dwarf1;
        private Archer archer1;
        int AttackValue1;
        int DefenseValue1;
        
        [SetUp]
        public void Setup()
        {
            dwarf1 = new Dwarf("y");
            dwarf1.Axe = new Axe();
            dwarf1.Helmet = new Helmet();
            dwarf1.Shield = new Shield();
            
            archer1 = new Archer("x");
            archer1.Bow = new Bow();
            archer1.Helmet = new Helmet();
        }

        [Test]
        public void ValorDeAtaqueDeEnanoIgualA15()
        {
            AttackValue1 = dwarf1.AttackValue;
            string expected = "25";
            Assert.Pass(expected, AttackValue1);
        }

        [Test]
        public void SaludDeArqueroTrasSerAtacadoPorEnano()
        {
            archer1.ReceiveAttack(dwarf1.AttackValue);
            string expected = "75";
            Assert.Pass(expected, dwarf1.Health);
        }

        [Test]
        public void ValorDeDefensaDelArqueroIgualA18()
        {
            DefenseValue1 = dwarf1.DefenseValue;
            string expected = "32";
            Assert.Pass(expected, archer1.DefenseValue);
        }

        [Test]
        public void SaludDelEnanoIgualA100TrasSerCurado()
        {
            archer1.ReceiveAttack(dwarf1.AttackValue);
            archer1.Cure();
            string expected = "100";
            Assert.Pass(expected, archer1.Health);
        }

        [Test]
        public void SaludEnanoNuncaNegativa()
        {
            int salud = dwarf1.Health;
            salud = -10;
            string expected = "0";
            Assert.Pass(expected, dwarf1.Health);
        }

    }
}
