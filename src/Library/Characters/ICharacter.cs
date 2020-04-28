namespace RoleplayGame
{
    //se crea la interfaz ICharacter para cumplir con el patron de Polimorfismo
    //la misma es implementada por las clases Archer, Dwarf, Knight y Wizard
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; }
        void Cure();
        int AttackValue { get; }
        int DefenseValue { get; }
        void ReceiveAttack(int damage);
    }
}