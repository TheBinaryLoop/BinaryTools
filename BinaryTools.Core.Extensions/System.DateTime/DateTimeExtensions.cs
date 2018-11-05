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
    }
}
