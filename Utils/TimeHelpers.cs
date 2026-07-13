namespace BlazorTemps.Utils;

public class TimeHelpers
{
    public static string FormatTimestamp(DateTime? timestamp)
    {
        if (!timestamp.HasValue)
        {
            return "N/A";
        }

        // 1. Force the incoming digits to be treated as UTC
        var utcTime = DateTime.SpecifyKind(timestamp.Value, DateTimeKind.Utc);

        // 2. Safely grab the Eastern rules 
        var easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

        // 3. Perform the conversion
        var easternTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, easternZone);
        var easternToday = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, easternZone).Date;

        // 4. Force standard US formatting rules natively
        var culture = new System.Globalization.CultureInfo("en-US");

        if (easternTime.Date == easternToday)
        {
            return easternTime.ToString("h:mm tt", culture); // e.g., 4:26 PM
        }

        return easternTime.ToString("M/d/yyyy h:mm tt", culture); // e.g., 7/10/2026 4:26 PM
    }
}