using ErrorOr;

namespace ItemGenerator.Domain.Common.Errors;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateUsername => Error.Conflict(
            code: nameof(DuplicateUsername),
            description: "Username already exists.");
    }
}