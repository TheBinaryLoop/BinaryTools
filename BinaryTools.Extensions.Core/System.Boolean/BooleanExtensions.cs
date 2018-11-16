using System;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Boolean"/> class.
    /// </summary>
    public static partial class BooleanExtensions
    {

        /// <summary>
        /// Executes an <see cref="Action"/> if the value is false.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> to act on.</param>
        /// <param name="action">The action to execute.</param>
        public static void IfFalse(this Boolean value, Action action)
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
        public static void IfTrue(this Boolean value, Action action)
        {
            if (value)
            {
                action();
            }
        }

        /// <summary>
        /// Converts this <see cref="Boolean"/> to an 8-bit unsigned integer.
        /// </summary>
        /// <param name="value">The <see cref="Boolean"/> to act on.</param>
        /// <returns>The number 1 if the value is true; otherwise, 0.</returns>
        public static Byte ToBinary(this Boolean value)
        {
            return Convert.ToByte(value);
        }

    }
}
