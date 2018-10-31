using System;

namespace BinaryTools.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Boolean"/> class.
    /// </summary>
    public static class BooleanExtensions
    {

        /// <summary>
        /// Executes an <see cref="Action"/> if the value is false.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> to act on.</param>
        /// <param name="action">The action to execute.</param>
        public static void IfFalse(this bool value, Action action)
        {
            if (!value)
            {
                action();
            }
        }

        /// <summary>
        /// Executes an <see cref="Action"/> if the value is true.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> to act on.</param>
        /// <param name="action">The action to execute.</param>
        public static void IfTrue(this bool value, Action action)
        {
            if (value)
            {
                action();
            }
        }

    }
}
