namespace RoleplayGame
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; }
        void Cure ();
        int AttackValue { get; }
        int DefenseValue { get; }
        void ReceiveAttack (int damage);
    }
}