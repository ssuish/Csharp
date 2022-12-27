class TimeConverter
{
    // Time Conversion
    /*
    Given a time in -hour AM/PM format, convert it to military (24-hour) time.

    Note: 
    - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
    - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
    */

    private static DateTime unformattedDate = new DateTime();

    private static DateTime TryConvertToDate(string date)
    {
        DateTime inputDate;
        bool isAccepted = DateTime.TryParse(date, out inputDate);
        return isAccepted ? inputDate : throw new FormatException("Invalid DateTime format.");
    }

    public static string timeConversion(string s)
    {
        unformattedDate = TryConvertToDate(s);
        return unformattedDate.ToString("HH:mm:ss");
    }
}