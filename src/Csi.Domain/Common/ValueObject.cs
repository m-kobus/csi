namespace Csi.Domain.Common;

internal abstract class ValueObject
{
    public abstract IEnumerable<object> GetEqualityComponents();

    public override bool Equals(object? other)
    {
        return other is null || other.GetType() != GetType()
            ? false
            : ((ValueObject)other)
                .GetEqualityComponents()
                .SequenceEqual(GetEqualityComponents());
    }
    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x?.GetHashCode() ?? 0)
            .Aggregate((x, y) => x ^ y);
    }
}
