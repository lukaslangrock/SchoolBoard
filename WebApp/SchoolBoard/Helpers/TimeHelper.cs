using System;

namespace SchoolBoard.Helpers
{
    public static class TimeHelper
    {
        public static DateTime GetUtcTime()
        {
            DateTime time = DateTime.UtcNow;
            return time;
        }

        // Index of timezones: https://support.microsoft.com/en-gb/help/973627/microsoft-time-zone-index-values
        public static DateTime GetLocalTime(string timezoneId)
        {
            DateTime time = DateTime.UtcNow;
            time = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(time, timezoneId);
            return time;
        }
    }
}
