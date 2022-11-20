using System.Reflection;

namespace ItemGenerator.Domain.Common;

public abstract class Enumeration<TEnum> : IEquatable<Enumeration<TEnum>>
    where TEnum : Enumeration<TEnum>
{
    protected Enumeration(byte value, string name)
    {
        Value = value;
        Name = name;
    }

    public readonly byte Value;
    public readonly string Name;
    private static readonly Dictionary<byte, TEnum> _enumerations = CreateEnumerations();

    public static List<TEnum> Enumerations(Func<TEnum, bool> predicate)
    {
        return _enumerations.Values.Where(predicate).ToList();
    }

    public static TEnum? FromValue(byte value)
    {
        return _enumerations.TryGetValue(value, out var enumeration)
            ? enumeration
            : default;
    }

    public static TEnum? FromName(string name)
    {
        return _enumerations.Values.FirstOrDefault(e => e.Name == name);
    }

    public bool Equals(Enumeration<TEnum>? other)
    {
        if (other is null)
            return false;

        return GetType() == other.GetType() && Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        return obj is Enumeration<TEnum> other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    private static Dictionary<byte, TEnum> CreateEnumerations()
    {
        var enumerationType = typeof(TEnum);

        var enumerations = enumerationType
            .GetFields(
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.FlattenHierarchy)
            .Where(fieldInfo => enumerationType.IsAssignableFrom(fieldInfo.FieldType))
            .Select(fieldInfo => (TEnum)fieldInfo.GetValue(default)!);

        return enumerations.ToDictionary(enumeration => enumeration.Value);
    }
}