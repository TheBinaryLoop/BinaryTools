using System;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="bool"/> class.
    /// </summary>
    public static partial class BooleanExtensions
    {

        /// <summary>
        /// Executes an <see cref="Action"/> if the value is false.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> to act on.</param>
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
        /// <param name="value">The <see cref="bool"/> to act on.</param>
        /// <param name="action">The action to execute.</param>
        public static void IfTrue(this bool value, Action action)
        {
            if (value)
            {
                action();
            }
        }

        /// <summary>
        /// Converts this <see cref="bool"/> to an 8-bit unsigned integer.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> to act on.</param>
        /// <returns>The number 1 if the value is true; otherwise, 0.</returns>
        public static Byte ToBinary(this bool value)
        {
            return Convert.ToByte(value);
        }

    }
}
