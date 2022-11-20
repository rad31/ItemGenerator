using ItemGenerator.Domain.Common;

namespace ItemGenerator.Domain.Enumerations;

public sealed class ProcType : Enumeration<ProcType>
{
    private ProcType(byte value, string name) : base(value, name) { }
    public static readonly ProcType OnAttack = new(0, "on Attack");
    public static readonly ProcType OnStrike = new(1, "on Strike");
    public static readonly ProcType WhenStruck = new(2, "when Struck");
}