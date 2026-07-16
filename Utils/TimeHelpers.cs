namespace BlazorTemps.Utils;

public class TimeHelpers
{
    // public static string FormatTimestamp(DateTime? timestamp)
    // {
    //     if (!timestamp.HasValue)
    //     {
    //         return "N/A";
    //     }


    //     // 1. Force the incoming digits to be treated as UTC
    //     var utcTime = DateTime.SpecifyKind(timestamp.Value, DateTimeKind.Utc);

    //     // 2. Safely grab the Eastern rules 
    //     var easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

    //     // 3. Perform the conversion
    //     var easternTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, easternZone);
    //     var easternToday = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, easternZone).Date;

    //     // 4. Force standard US formatting rules natively
    //     var culture = new System.Globalization.CultureInfo("en-US");

    //     if (easternTime.Date == easternToday)
    //     {
    //         return easternTime.ToString("h:mm tt", culture); // e.g., 4:26 PM
    //     }

    //     return easternTime.ToString("M/d/yyyy h:mm tt", culture); // e.g., 7/10/2026 4:26 PM
    // }

    public static string FormatTimestamp(DateTime? timestamp)
    {
        if (!timestamp.HasValue)
        {
            return "N/A";
        }

        var easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        DateTime displayTime = timestamp.Value;

        // Safety check: If the time is explicitly marked as UTC, convert it.
        // If it is Unspecified (which is what your new Select statement yields), it bypasses this.
        if (displayTime.Kind == DateTimeKind.Utc)
        {
            displayTime = TimeZoneInfo.ConvertTimeFromUtc(displayTime, easternZone);
        }

        // Get today's date in Eastern Time for an accurate comparison
        var easternToday = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, easternZone).Date;
        var culture = new System.Globalization.CultureInfo("en-US");

        // Compare just the Date components
        if (displayTime.Date == easternToday)
        {
            return displayTime.ToString("h:mm tt", culture); // e.g., 4:26 PM
        }

        return displayTime.ToString("M/d/yyyy h:mm tt", culture); // e.g., 7/10/2026 4:26 PM
    }

}