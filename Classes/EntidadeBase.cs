namespace DIO.Series
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; } //propriedade Id - Todo mundo que herdar esta classe terá um id por default
    }
}