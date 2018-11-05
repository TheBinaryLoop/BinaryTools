using System;

namespace BinaryTools.Core.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="DateTime"/> class.
    /// </summary>
    public static partial class DateTimeExtensions
    {

        /// <summary>
        /// Gets the age of the current DateTime object until now in years.
        /// </summary>
        /// <param name="src">The DateTime object to act on.</param>
        /// <returns>The age of the current DateTime object until now in years.</returns>
        public static Int32 GetAge(this DateTime src)
        {
            if (DateTime.Today.Month < src.Month ||
                DateTime.Today.Month == src.Month &&
                DateTime.Today.Day < src.Day)
            {
                return DateTime.Today.Year - src.Year - 1;
            }
            return DateTime.Today.Year - src.Year;
        }

        /// <summary>
        /// Gets the elapsed time between this DateTime object and now.
        /// </summary>
        /// <param name="datetime">The DateTime object to act on.</param>
        /// <returns>The elapsed time between this DateTime object and now.</returns>
        public static TimeSpan Elapsed(this DateTime datetime)
        {
            return DateTime.Now - datetime;
        }

        /// <summary>
        /// Sets the time to "23:59:59:999".
        /// </summary>
        /// <param name="datetime">The DateTime object to act on.</param>
        /// <returns>A new DateTime object with the time set to "23:59:59:999".</returns>
        public static DateTime EndOfDay(this DateTime datetime)
        {
            return new DateTime(datetime.Year, datetime.Month, datetime.Day).AddDays(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

    }
}
