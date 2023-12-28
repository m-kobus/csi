namespace Csi.Domain.Common;

internal abstract class Entity
{
    public Guid Id { get; init; }
    
    protected Entity(Guid id) => Id = id; 
    protected Entity() { }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    public override bool Equals(object? other)
    {
        return other is not null && other.GetType() == GetType();
    }
}
