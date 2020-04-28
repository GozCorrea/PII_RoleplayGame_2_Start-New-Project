namespace RoleplayGame
{
    //se crea interfaz IDefenseElement (que a su vez implementa la interfaz IElement) 
    //para cumplir con el patron de Polimorfismo
    //la misma es implementada por las clases de Items no magicos que tienen valor de defensa (Armor, Helmet y Shield)
    public interface IDefenseElement : IElement
    {
        int DefenseValue { get; }
    }
}