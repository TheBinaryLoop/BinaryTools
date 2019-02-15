using System;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="TimeSpan"/> class.
    /// </summary>
    public static partial class TimeSpanExtensions
    {

        public static int GetYears(this TimeSpan timespan)
        {
            return (int)(timespan.Days / 365.2425);
        }
        public static int GetMonths(this TimeSpan timespan)
        {
            return (int)(timespan.Days / 30.436875);
        }

    }
}
