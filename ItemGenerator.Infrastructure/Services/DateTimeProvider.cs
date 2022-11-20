using ItemGenerator.Application.Common.Interfaces.Services;

namespace ItemGenerator.Infrastructure.Services;

public sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}