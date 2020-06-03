using System;
using TimeZoneConverter;

namespace SchoolBoard.Helpers
{
    public static class TimeHelper
    {
        public static DateTime GetUtcTime()
        {
            DateTime time = DateTime.UtcNow;
            return time;
        }

        // Timezone value in appsettings.json can be either in Windows or IANA (used by Unix systems) format
        public static DateTime GetLocalTime(string timezoneId)
        {
            DateTime datetime = DateTime.UtcNow;
            TimeZoneInfo timezone = TZConvert.GetTimeZoneInfo(timezoneId);
            datetime = TimeZoneInfo.ConvertTime(datetime, timezone);
            return datetime;
        }
    }
}
