using System;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="TimeSpan"/> class.
    /// </summary>
    public static partial class TimeSpanExtensions
    {

        public static Int32 GetYears(this TimeSpan timespan)
        {
            return (Int32)(timespan.Days / 365.2425);
        }
        public static Int32 GetMonths(this TimeSpan timespan)
        {
            return (Int32)(timespan.Days / 30.436875);
        }

    }
}
