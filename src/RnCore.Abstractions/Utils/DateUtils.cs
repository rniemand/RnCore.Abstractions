namespace RnCore.Abstractions.Utils;

public static class DateUtils
{
  public static DateTime ToStartOfDay(DateTime date) => new(date.Year, date.Month, date.Day);
}
