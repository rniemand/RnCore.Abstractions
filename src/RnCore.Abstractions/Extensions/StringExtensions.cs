namespace RnCore.Abstractions.Extensions;

public static class StringExtensions
{
  public static bool IgnoreCaseEquals(this string s, string value) =>
    s.Equals(value, StringComparison.InvariantCultureIgnoreCase);

  public static bool IgnoreCaseStartsWith(this string s, string value) =>
    s.StartsWith(value, StringComparison.InvariantCultureIgnoreCase);

  public static bool IgnoreCaseEndsWith(this string s, string value) =>
    s.EndsWith(value, StringComparison.InvariantCultureIgnoreCase);

  public static bool IgnoreCaseContains(this string s, string value) =>
    s.Contains(value, StringComparison.InvariantCultureIgnoreCase);
}
