using System;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Int32"/> class.
    /// </summary>
    public static partial class Int32Extensions
    {
        /// <summary>
        /// Converts the numeric value of this instance to its equivalent hexadecimal representation.
        /// </summary>
        /// <param name="value">The Int32 to act on.</param>
        /// <returns>The hexadecimal representation of the value of this instance.</returns>
        public static string ToHex(this Int32 value)
        {
            return String.Format("0x{0:X}", value);
        }

        /// <summary>
        /// Converts an arabic number to an roman string.
        /// </summary>
        /// <param name="value">The Int32 to act on.</param>
        /// <returns>Returns the converted value.</returns>
        public static string ToRoman(this Int32 value)
        {
            string[] ThouLetters = { "", "M", "MM", "MMM" };
            string[] HundLetters = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] TensLetters = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] OnesLetters = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            // See if it's >= 4000.
            if (value >= 4000)
            {
                // Use parentheses.
                int thou = value / 1000;
                value %= 1000;
                return "(" + ToRoman(thou) + ")" + ToRoman(value);
            }

            // Otherwise process the letters.
            string result = "";

            // Pull out thousands.
            int num;
            num = value / 1000;
            result += ThouLetters[num];
            value %= 1000;

            // Handle hundreds.
            num = value / 100;
            result += HundLetters[num];
            value %= 100;

            // Handle tens.
            num = value / 10;
            result += TensLetters[num];
            value %= 10;

            // Handle ones.
            result += OnesLetters[value];

            return result;
        }

    }
}
