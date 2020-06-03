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

        // Timezone in appsettings.json can be either a Windors or IANA (used by Unix systems)
        public static DateTime GetLocalTime(string timezoneId)
        {
            DateTime datetime = DateTime.UtcNow;
            TimeZoneInfo timezone = TZConvert.GetTimeZoneInfo(timezoneId);
            datetime = TimeZoneInfo.ConvertTime(datetime, timezone);
            return datetime;
        }
    }
}
