using NUnit.Framework;
using RoleplayGame;

namespace Libraty.Test
{
    public class SpellBookTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSpellBookValorAtack()
        {
            const int expected = 70;
            SpellsBook test = new SpellsBook();
           test.Spells = new Spell[]{ new Spell() };
            
            
            Assert.AreEqual(expected, test.AttackValue);
        }
        public void TestSpellBookValorDefense()
        {
            const int expected = 70;
            SpellsBook test = new SpellsBook();
           test.Spells = new Spell[]{ new Spell() };
            
            
            Assert.AreEqual(expected, test.DefenseValue);
        }
    }
}