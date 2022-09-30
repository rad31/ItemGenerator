using ErrorOr;

namespace ItemGenerator.Domain.Common.Errors;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Custom(
            type: (int)ErrorTypesExtended.Authorization,
            code: nameof(InvalidCredentials),
            description: "Invalid credentials.");
    }
}