using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="char"/> class.
    /// </summary>
    public static partial class CharExtensions
    {
        /// <summary>
        /// Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.
        /// </summary>
        /// <param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF).</param>
        /// <param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF).</param>
        /// <returns>The 21-bit Unicode code point represented by the highSurrogate and lowSurrogate parameters.</returns>
        public static int ConvertToUtf32(this char highSurrogate, char lowSurrogate)
        {
            return char.ConvertToUtf32(highSurrogate, lowSurrogate);
        }

        /// <summary>
        /// Converts the specified numeric Unicode character to a double-precision floating point number.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The numeric value of c if that character represents a number; otherwise, -1.0.</returns>
        public static double GetNumericValue(this char c)
        {
            return char.GetNumericValue(c);
        }

#if !NETSTANDARD1_3

        /// <summary>
        /// Categorizes a specified Unicode character into a group identified by one of the <see cref="UnicodeCategory"/> values.
        /// </summary>
        /// <param name="c">The Unicode character to categorize.</param>
        /// <returns>A <see cref="UnicodeCategory"/> value that identifies the group that contains c.</returns>
        public static UnicodeCategory GetUnicodeCategory(this char c)
        {
            return char.GetUnicodeCategory(c);
        }

#endif

        /// <summary>
        /// Determines whether the char is inside of the provided values.
        /// </summary>
        /// <param name="c">The char to be compared.</param>
        /// <param name="values">The value list to compare with the char.</param>
        /// <returns>true if the values list contains the char, else false.</returns>
        public static bool In(this char c, params char[] values)
        {
            return Array.IndexOf(values, c) != -1;
        }

        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as a control character.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a control character; otherwise, false.</returns>
        public static bool IsControl(this char c)
        {
            return char.IsControl(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a decimal digit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a decimal digit; otherwise, false.</returns>
        public static bool IsDigit(this char c)
        {
            return char.IsDigit(c);
        }

        /// <summary>
        /// Indicates whether this char object is a high surrogate.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if the numeric value of the c parameter ranges from U+D800 through U+DBFF; otherwise, false.</returns>
        public static bool IsHighSurrogate(this char c)
        {
            return char.IsHighSurrogate(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a Unicode letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a letter; otherwise, false.</returns>
        public static bool IsLetter(this char c)
        {
            return char.IsLetter(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a letter or a decimal digit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a letter or a decimal digit; otherwise, false.</returns>
        public static bool IsLetterOrDigit(this char c)
        {
            return char.IsLetterOrDigit(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a lowercase letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a lowercase letter; otherwise, false.</returns>
        public static bool IsLower(this char c)
        {
            return char.IsLower(c);
        }

        /// <summary>
        /// Indicates whether this char object is a low surrogate.
        /// </summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if the numeric value of the c parameter ranges from U+DC00 through U+DFFF; otherwise, false.</returns>
        public static bool IsLowSurrogate(this char c)
        {
            return char.IsLowSurrogate(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a number.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a number; otherwise, false.</returns>
        public static bool IsNumber(this char c)
        {
            return char.IsNumber(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a punctuation mark.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a punctuation mark; otherwise, false.</returns>
        public static bool IsPunctuation(this char c)
        {
            return char.IsPunctuation(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a separator character.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a separator character; otherwise, false.</returns>
        public static bool IsSeparator(this char c)
        {
            return char.IsSeparator(c);
        }

        /// <summary>
        /// Indicates whether this character has a surrogate code unit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is either a high surrogate or a low surrogate; otherwise, false.</returns>
        public static bool IsSurrogate(this char c)
        {
            return char.IsSurrogate(c);
        }

        /// <summary>
        /// Indicates whether the two specified char objects form a surrogate pair.
        /// </summary>
        /// <param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair.</param>
        /// <param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair.</param>
        /// <returns>
        /// true if the numeric value of the highSurrogate parameter ranges from U+D800 through U+DBFF, and the numeric value of the 
        /// lowSurrogate parameter ranges from U+DC00 through U+DFFF; otherwise, false.
        /// </returns>
        public static bool IsSurrogatePair(this char highSurrogate, char lowSurrogate)
        {
            return char.IsSurrogatePair(highSurrogate, lowSurrogate);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a symbol character.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a symbol character; otherwise, false.</returns>
        public static bool IsSymbol(this char c)
        {
            return char.IsSymbol(c);
        }

        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as an uppercase letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is an uppercase letter; otherwise, false.</returns>
        public static bool IsUpper(this char c)
        {
            return char.IsUpper(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as white space.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is white space; otherwise, false.</returns>
        public static bool IsWhiteSpace(this char c)
        {
            return char.IsWhiteSpace(c);
        }

        #region ToLower

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts the value of this Unicode character to its lowercase equivalent using specified culture-specific formatting information.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>The lowercase equivalent of c, modified according to culture, or the unchanged value of c, if c is already lowercase or not alphabetic.</returns>
        public static char ToLower(this char c, CultureInfo culture)
        {
            return char.ToLower(c, culture);
        }

#endif

        /// <summary>
        /// Converts the value of this Unicode character to its lowercase equivalent.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The lowercase equivalent of c, or the unchanged value of c, if c is already lowercase or not alphabetic.</returns>
        public static char ToLower(this char c)
        {
            return char.ToLower(c);
        }

        #endregion

        /// <summary>
        /// Converts the value of this Unicode character to its lowercase equivalent using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The lowercase equivalent of the c parameter, or the unchanged value of c, if c is already lowercase or not alphabetic.</returns>
        public static char ToLowerInvariant(this char c)
        {
            return char.ToLowerInvariant(c);
        }

        #region ToUpper

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts the value of this specified Unicode character to its uppercase equivalent using specified culture-specific formatting information.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns></returns>
        public static char ToUpper(this char c, CultureInfo culture)
        {
            return char.ToUpper(c, culture);
        }

#endif

        /// <summary>
        /// Converts the value of this Unicode character to its uppercase equivalent.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The uppercase equivalent of c, or the unchanged value of c if c is already uppercase, has no uppercase equivalent, or is not alphabetic.</returns>
        public static char ToUpper(this char c)
        {
            return char.ToUpper(c);
        }

        #endregion

        /// <summary>
        /// Converts the value of this Unicode character to its uppercase equivalent using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The uppercase equivalent of the c parameter, or the unchanged value of c, if c is already uppercase or not alphabetic.</returns>
        public static char ToUpperInvariant(this char c)
        {
            return char.ToUpperInvariant(c);
        }

        /// <summary>
        /// Repeats a character the specified number of times.
        /// </summary>
        /// <param name="src">The char to act on.</param>
        /// <param name="repeatCount">The number of repeats.</param>
        /// <returns>A string containing the repeated char.</returns>
        public static string Repeat(this char src, int repeatCount)
        {
            return new string(src, repeatCount);
        }

        /// <summary>
        /// Enumerates from current char to toCharacter.
        /// </summary>
        /// <param name="src">The char to act on.</param>
        /// <param name="toCharacter">Target character.</param>
        /// <returns>An enumerator that allows loops to be used to process src to toCharacter.</returns>
        public static IEnumerable<char> To(this char src, char toCharacter)
        {
            bool reverseRequired = (src > toCharacter);

            char first = reverseRequired ? toCharacter : src;
            char last = reverseRequired ? src : toCharacter;

            IEnumerable<char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (char)charCode);

            if (reverseRequired)
            {
                result = result.Reverse();
            }

            return result;
        }

    }
}
