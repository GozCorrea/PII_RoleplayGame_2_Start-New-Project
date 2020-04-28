namespace RoleplayGame
{
    //se crea ISpell como forma de abstraccion para el caso que se agregue otra clase con hechizos
    //implementado por la clase Spell
    //patron usado Polimorfismo
    public interface ISpell
    {
        int AttackValue { get; }
        int DefenseValue { get; }
    }
}