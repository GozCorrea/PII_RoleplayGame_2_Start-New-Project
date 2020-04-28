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
            int expected = 170;
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard test = new Wizard("Gandalf");
            test.Staff = new Staff();
            test.SpellsBook = book;

            Assert.AreEqual(expected , test.AttackValue);
        }
        [Test]
        public void TestWzardValorDefense()
        {
            int expected = 170;
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard test = new Wizard("Gandalf");
            test.Staff = new Staff();
            test.SpellsBook = book;

            Assert.AreEqual(expected , test.DefenseValue);
        }
        
    }
}