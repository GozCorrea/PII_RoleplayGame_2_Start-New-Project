namespace RoleplayGame
{
    //se crea interfaz IAttackElement (que a su vez implementa la interfaz IElement) 
    //para cumplir con el patron de Polimorfismo
    //la misma es implementada por las clases de Items no magicos que atacan (Axe, Bow y Sword)

    public interface IAttackElement : IElement
    {
        int AttackValue { get; }
    }
}