namespace WeirdCode;

public static class DateTimeExtensions
{
    public static DateTime January(this int day, int year)
    {
        return new DateTime(year, 01, day);
    } 
}