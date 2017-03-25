using System;

namespace Sample.Services.SettingsServices
{
    public static class StringExtensions
    {
        public static T ToEnum<T>(this string value) where T : struct
        {
            if (Enum.TryParse<T>(value, out var result))
            {
                return result;
            }
            else
            {
                return default(T);
            }
        }

        public static TimeSpan ToTimeSpan(this string value)
        {
            if (TimeSpan.TryParse(value, out var result))
            {
                return result;
            }
            else
            {
                return TimeSpan.Zero;
            }
        }
    }

}
