namespace RoleplayGame
{
    //se crea la interfaz IMagicElement como forma de abstraccion para los elementos no magicos
    public interface IMagicElement 
    {
        int DefenseValue { get; }
        int AttackValue { get; }
    }
}