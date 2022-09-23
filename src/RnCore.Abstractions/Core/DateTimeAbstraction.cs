using System.Diagnostics.CodeAnalysis;

namespace RnCore.Abstractions;

public interface IDateTimeAbstraction
{
  DateTime MinValue { get; }
  DateTime MaxValue { get; }
  DateTime Now { get; }
  DateTime UtcNow { get; }
}

[ExcludeFromCodeCoverage]
public class DateTimeAbstraction : IDateTimeAbstraction
{
  public DateTime MinValue => DateTime.MinValue;
  public DateTime MaxValue => DateTime.MaxValue;
  public DateTime Now => DateTime.Now;
  public DateTime UtcNow => DateTime.UtcNow;
}
