using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Char"/> class.
    /// </summary>
    public static partial class CharExtensions
    {
        /// <summary>
        /// Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.
        /// </summary>
        /// <param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF).</param>
        /// <param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF).</param>
        /// <returns>The 21-bit Unicode code point represented by the highSurrogate and lowSurrogate parameters.</returns>
        public static Int32 ConvertToUtf32(this Char highSurrogate, Char lowSurrogate)
        {
            return Char.ConvertToUtf32(highSurrogate, lowSurrogate);
        }

        /// <summary>
        /// Converts the specified numeric Unicode character to a double-precision floating point number.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The numeric value of c if that character represents a number; otherwise, -1.0.</returns>
        public static Double GetNumericValue(this Char c)
        {
            return Char.GetNumericValue(c);
        }

#if !NETSTANDARD1_3

        /// <summary>
        /// Categorizes a specified Unicode character into a group identified by one of the <see cref="UnicodeCategory"/> values.
        /// </summary>
        /// <param name="c">The Unicode character to categorize.</param>
        /// <returns>A <see cref="UnicodeCategory"/> value that identifies the group that contains c.</returns>
        public static UnicodeCategory GetUnicodeCategory(this Char c)
        {
            return Char.GetUnicodeCategory(c);
        }

#endif

        /// <summary>
        /// Determines whether the char is inside of the provided values.
        /// </summary>
        /// <param name="c">The char to be compared.</param>
        /// <param name="values">The value list to compare with the char.</param>
        /// <returns>true if the values list contains the char, else false.</returns>
        public static Boolean In(this Char c, params Char[] values)
        {
            return Array.IndexOf(values, c) != -1;
        }

        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as a control character.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a control character; otherwise, false.</returns>
        public static Boolean IsControl(this Char c)
        {
            return Char.IsControl(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a decimal digit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a decimal digit; otherwise, false.</returns>
        public static Boolean IsDigit(this Char c)
        {
            return Char.IsDigit(c);
        }

        /// <summary>
        /// Indicates whether this Char object is a high surrogate.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if the numeric value of the c parameter ranges from U+D800 through U+DBFF; otherwise, false.</returns>
        public static Boolean IsHighSurrogate(this Char c)
        {
            return Char.IsHighSurrogate(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a Unicode letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a letter; otherwise, false.</returns>
        public static Boolean IsLetter(this Char c)
        {
            return Char.IsLetter(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a letter or a decimal digit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a letter or a decimal digit; otherwise, false.</returns>
        public static Boolean IsLetterOrDigit(this Char c)
        {
            return Char.IsLetterOrDigit(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a lowercase letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a lowercase letter; otherwise, false.</returns>
        public static Boolean IsLower(this Char c)
        {
            return Char.IsLower(c);
        }

        /// <summary>
        /// Indicates whether this Char object is a low surrogate.
        /// </summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if the numeric value of the c parameter ranges from U+DC00 through U+DFFF; otherwise, false.</returns>
        public static Boolean IsLowSurrogate(this Char c)
        {
            return Char.IsLowSurrogate(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a number.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a number; otherwise, false.</returns>
        public static Boolean IsNumber(this Char c)
        {
            return Char.IsNumber(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a punctuation mark.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a punctuation mark; otherwise, false.</returns>
        public static Boolean IsPunctuation(this Char c)
        {
            return Char.IsPunctuation(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a separator character.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a separator character; otherwise, false.</returns>
        public static Boolean IsSeparator(this Char c)
        {
            return Char.IsSeparator(c);
        }

        /// <summary>
        /// Indicates whether this character has a surrogate code unit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is either a high surrogate or a low surrogate; otherwise, false.</returns>
        public static Boolean IsSurrogate(this Char c)
        {
            return Char.IsSurrogate(c);
        }

        /// <summary>
        /// Indicates whether the two specified Char objects form a surrogate pair.
        /// </summary>
        /// <param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair.</param>
        /// <param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair.</param>
        /// <returns>
        /// true if the numeric value of the highSurrogate parameter ranges from U+D800 through U+DBFF, and the numeric value of the 
        /// lowSurrogate parameter ranges from U+DC00 through U+DFFF; otherwise, false.
        /// </returns>
        public static Boolean IsSurrogatePair(this Char highSurrogate, Char lowSurrogate)
        {
            return Char.IsSurrogatePair(highSurrogate, lowSurrogate);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as a symbol character.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is a symbol character; otherwise, false.</returns>
        public static Boolean IsSymbol(this Char c)
        {
            return Char.IsSymbol(c);
        }

        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as an uppercase letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is an uppercase letter; otherwise, false.</returns>
        public static Boolean IsUpper(this Char c)
        {
            return Char.IsUpper(c);
        }

        /// <summary>
        /// Indicates whether this Unicode character is categorized as white space.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>true if c is white space; otherwise, false.</returns>
        public static Boolean IsWhiteSpace(this Char c)
        {
            return Char.IsWhiteSpace(c);
        }

        #region ToLower

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts the value of this Unicode character to its lowercase equivalent using specified culture-specific formatting information.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>The lowercase equivalent of c, modified according to culture, or the unchanged value of c, if c is already lowercase or not alphabetic.</returns>
        public static Char ToLower(this Char c, CultureInfo culture)
        {
            return Char.ToLower(c, culture);
        }

#endif

        /// <summary>
        /// Converts the value of this Unicode character to its lowercase equivalent.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The lowercase equivalent of c, or the unchanged value of c, if c is already lowercase or not alphabetic.</returns>
        public static Char ToLower(this Char c)
        {
            return Char.ToLower(c);
        }

        #endregion

        /// <summary>
        /// Converts the value of this Unicode character to its lowercase equivalent using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The lowercase equivalent of the c parameter, or the unchanged value of c, if c is already lowercase or not alphabetic.</returns>
        public static Char ToLowerInvariant(this Char c)
        {
            return Char.ToLowerInvariant(c);
        }

        #region ToUpper

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts the value of this specified Unicode character to its uppercase equivalent using specified culture-specific formatting information.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns></returns>
        public static Char ToUpper(this Char c, CultureInfo culture)
        {
            return Char.ToUpper(c, culture);
        }

#endif

        /// <summary>
        /// Converts the value of this Unicode character to its uppercase equivalent.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The uppercase equivalent of c, or the unchanged value of c if c is already uppercase, has no uppercase equivalent, or is not alphabetic.</returns>
        public static Char ToUpper(this Char c)
        {
            return Char.ToUpper(c);
        }

        #endregion

        /// <summary>
        /// Converts the value of this Unicode character to its uppercase equivalent using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The uppercase equivalent of the c parameter, or the unchanged value of c, if c is already uppercase or not alphabetic.</returns>
        public static Char ToUpperInvariant(this Char c)
        {
            return Char.ToUpperInvariant(c);
        }

        /// <summary>
        /// Repeats a character the specified number of times.
        /// </summary>
        /// <param name="src">The char to act on.</param>
        /// <param name="repeatCount">The number of repeats.</param>
        /// <returns>A string containing the repeated char.</returns>
        public static String Repeat(this Char src, Int32 repeatCount)
        {
            return new String(src, repeatCount);
        }

        /// <summary>
        /// Enumerates from current char to toCharacter.
        /// </summary>
        /// <param name="src">The char to act on.</param>
        /// <param name="toCharacter">Target character.</param>
        /// <returns>An enumerator that allows loops to be used to process src to toCharacter.</returns>
        public static IEnumerable<Char> To(this Char src, Char toCharacter)
        {
            bool reverseRequired = (src > toCharacter);

            Char first = reverseRequired ? toCharacter : src;
            Char last = reverseRequired ? src : toCharacter;

            IEnumerable<Char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (Char)charCode);

            if (reverseRequired)
            {
                result = result.Reverse();
            }

            return result;
        }

    }
}
