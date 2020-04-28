using NUnit.Framework;
using RoleplayGame;
namespace Libraty.Test
{
    public class WizardTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWzardValorAtack()
        {
            const int expected = 170;
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard test = new Wizard("wizardTest");
            
            Assert.AreEqual(expected,test.AttackValue);
        }
        public void TestWzardValorDefense()
        {
            const int expected = 170;
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard test = new Wizard("wizardTest");
            
            Assert.AreEqual(expected,test.DefenseValue);
        }
    }
}