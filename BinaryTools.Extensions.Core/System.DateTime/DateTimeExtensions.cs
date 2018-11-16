using System;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="DateTime"/> class.
    /// </summary>
    public static partial class DateTimeExtensions
    {

        /// <summary>
        /// Gets the age of the current DateTime object until now in years.
        /// </summary>
        /// <param name="dateTime">The DateTime object to act on.</param>
        /// <returns>The age of the current DateTime object until now in years.</returns>
        public static Int32 GetAge(this DateTime dateTime)
        {
            if (DateTime.Today.Month < dateTime.Month ||
                DateTime.Today.Month == dateTime.Month &&
                DateTime.Today.Day < dateTime.Day)
            {
                return DateTime.Today.Year - dateTime.Year - 1;
            }
            return DateTime.Today.Year - dateTime.Year;
        }

        /// <summary>
        /// Gets the elapsed time between this DateTime object and now.
        /// </summary>
        /// <param name="dateTime">The DateTime object to act on.</param>
        /// <returns>The elapsed time between this DateTime object and now.</returns>
        public static TimeSpan Elapsed(this DateTime dateTime)
        {
            return DateTime.Now - dateTime;
        }

        /// <summary>
        /// Sets the time to "23:59:59:999".
        /// </summary>
        /// <param name="dateTime">The DateTime object to act on.</param>
        /// <returns>A new DateTime object with the time set to "23:59:59:999".</returns>
        public static DateTime EndOfDay(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

        /// <summary>
        /// Returns a DateTime of the last day of the month with the time set to "23:59:59:999".
        /// </summary>
        /// <param name="dateTime">The DateTime object to act on.</param>
        /// <returns>A DateTime of the last day of the month with the time set to "23:59:59:999".</returns>
        public static DateTime EndOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

        /// <summary>
        /// Returns a DateTime of the last day of the week with the time set to "23:59:59:999".
        /// </summary>
        /// <param name="dateTime">The DateTime object to act on.</param>
        /// <param name="startDayOfWeek">(Optional) the start day of week.</param>
        /// <returns>A DateTime of the last day of the week with the time set to "23:59:59:999".</returns>
        public static DateTime EndOfWeek(this DateTime dateTime, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
        {
            DateTime end = dateTime;
            DayOfWeek endDayOfWeek = startDayOfWeek - 1;
            if (endDayOfWeek < 0)
            {
                endDayOfWeek = DayOfWeek.Saturday;
            }

            if (end.DayOfWeek != endDayOfWeek)
            {
                if (endDayOfWeek < end.DayOfWeek)
                {
                    end = end.AddDays(7 - (end.DayOfWeek - endDayOfWeek));
                }
                else
                {
                    end = end.AddDays(endDayOfWeek - end.DayOfWeek);
                }
            }

            return new DateTime(end.Year, end.Month, end.Day, 23, 59, 59, 999);
        }

        /// <summary>
        /// Returns a DateTime of the last day of the year with the time set to "23:59:59:999".
        /// </summary>
        /// <param name="dateTime">The DateTime object to act on.</param>
        /// <returns>A DateTime of the last day of the year with the time set to "23:59:59:999".</returns>
        public static DateTime EndOfYear(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

    }
}
