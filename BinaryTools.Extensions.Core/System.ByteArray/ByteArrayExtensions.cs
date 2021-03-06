﻿using System;
using System.IO;
using System.Text;
#if !NETSTANDARD1_3
using System.Drawing;
using System.Web;
#endif

namespace BinaryTools.Extensions.Core
{

    /// <summary>
    /// A collection of helpful extension methods for byte arrays.
    /// </summary>
    public static partial class ByteArrayExtensions
    {
        ///// <summary>
        ///// Decompresses the byte array with gzip to a <see cref="string"/>.
        ///// </summary>
        ///// <param name="src">The byte array to act on.</param>
        ///// <returns>The decompressed string.</returns>
        //public static string DecompressGZip(this Byte[] src)
        //{
        //    const int bufferSize = 1024;
        //    using (var memoryStream = new MemoryStream(src))
        //    {
        //        using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
        //        {
        //            // Memory stream for storing the decompressed bytes
        //            using (var outStream = new MemoryStream())
        //            {
        //                var buffer = new byte[bufferSize];
        //                int totalBytes = 0;
        //                int readBytes;
        //                while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
        //                {
        //                    outStream.Write(buffer, 0, readBytes);
        //                    totalBytes += readBytes;
        //                }
        //                return Encoding.Default.GetString(outStream.GetBuffer(), 0, totalBytes);
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// Decompresses the byte array with gzip to a <see cref="string"/>.
        ///// </summary>
        ///// <param name="src">The byte array to act on.</param>
        ///// <param name="encoding">The <see cref="Encoding"/> to use.</param>
        ///// <returns>The decompressed string.</returns>
        //public static string DecompressGZip(this Byte[] src, Encoding encoding)
        //{
        //    const int bufferSize = 1024;
        //    using (var memoryStream = new MemoryStream(src))
        //    {
        //        using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
        //        {
        //            // Memory stream for storing the decompressed bytes
        //            using (var outStream = new MemoryStream())
        //            {
        //                var buffer = new byte[bufferSize];
        //                int totalBytes = 0;
        //                int readBytes;
        //                while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
        //                {
        //                    outStream.Write(buffer, 0, readBytes);
        //                    totalBytes += readBytes;
        //                }
        //                return encoding.GetString(outStream.GetBuffer(), 0, totalBytes);
        //            }
        //        }
        //    }
        //}

        public static int Find(this byte[] src, byte[] find, int startIndex = 0)
        {
            int index = -1;
            int matchIndex = 0;
            // handle the complete source array
            for (int i = startIndex; i < src.Length; i++)
            {
                if (src[i] == find[matchIndex])
                {
                    if (matchIndex == (find.Length - 1))
                    {
                        index = i - matchIndex;
                        break;
                    }
                    matchIndex++;
                }
                else
                {
                    matchIndex = 0;
                }

            }
            return index;
        }

        public static int FindString(this byte[] src, string tofind, int startIndex = 0)
        {
            if (startIndex < 0) return -1;
            int index = -1;
            int matchIndex = 0;
            // handle the complete source array
            byte[] find = Encoding.ASCII.GetBytes(tofind);
            for (int i = startIndex; i < src.Length; i++)
            {
                if (src[i] == find[matchIndex])
                {
                    if (matchIndex == (find.Length - 1))
                    {
                        index = i - matchIndex;
                        break;
                    }
                    matchIndex++;
                }
                else
                {
                    matchIndex = 0;
                }

            }
            return index;
        }

        public static string GetBetween(this byte[] src, int start, int end)
        {
            byte[] dst = null;
            dst = new byte[end - start];
            Buffer.BlockCopy(src, start, dst, 0, (end - start));
            return Encoding.ASCII.GetString(dst);
        }

        public static byte[] GetInBetween(this byte[] src, int start, int end)
        {
            byte[] dst = null;
            dst = new byte[end - start];
            Buffer.BlockCopy(src, start, dst, 0, (end - start));
            return dst;
        }

        public static byte[] Replace(this byte[] src, byte[] search, byte[] repl)
        {
            byte[] dst = null;
            int index = src.Find(search);
            if (index >= 0)
            {
                dst = new byte[src.Length - search.Length + repl.Length];
                // before found array
                Buffer.BlockCopy(src, 0, dst, 0, index);
                // repl copy
                Buffer.BlockCopy(repl, 0, dst, index, repl.Length);
                // rest of src array
                Buffer.BlockCopy(
                    src,
                    index + search.Length,
                    dst,
                    index + repl.Length,
                    src.Length - (index + search.Length));
                return dst;
            }
            return src;
        }

        public static byte[] ReplaceString(this byte[] src, string srch, string replace)
        {
            byte[] search = Encoding.ASCII.GetBytes(srch);
            byte[] repl = Encoding.ASCII.GetBytes(replace);
            byte[] dst = null;
            int index = src.Find(search);
            if (index >= 0)
            {
                dst = new byte[src.Length - search.Length + repl.Length];
                // before found array
                Buffer.BlockCopy(src, 0, dst, 0, index);
                // repl copy
                Buffer.BlockCopy(repl, 0, dst, index, repl.Length);
                // rest of src array
                Buffer.BlockCopy(
                    src,
                    index + search.Length,
                    dst,
                    index + repl.Length,
                    src.Length - (index + search.Length));
                return dst;
            }
            return src;
        }

        public static byte[] ReplaceBetween(this byte[] src, string start, string end, string replacement)
        {
            byte[] dst = null;
            //locate both.
            int index = src.FindString(start);
            int index1 = src.FindString(end, index);
            if (index > -1 && index1 > -1)
            {
                dst = new byte[src.Length - (index - index1) + replacement.Length];
                // before found array
                Buffer.BlockCopy(src, 0, dst, 0, index);
                // repl copy
                Buffer.BlockCopy(Encoding.ASCII.GetBytes(replacement), 0, dst, index, replacement.Length);
                // rest of src array
                Buffer.BlockCopy(
                    src,
                    index + (index1 - index),
                    dst,
                    index + replacement.Length,
                    src.Length - (index + (index1 - index)));
            }
            return dst;
        }

        public static byte[] ReplaceBetween(this byte[] src, int start, int end, byte[] replacement)
        {
            byte[] dst = null;
            dst = new byte[src.Length - (end - start) + replacement.Length];
            // before found array
            Buffer.BlockCopy(src, 0, dst, 0, start);
            // repl copy
            Buffer.BlockCopy(replacement, 0, dst, start, replacement.Length);
            // rest of src array
            Buffer.BlockCopy(
                src,
                start + (end - start),
                dst,
                start + replacement.Length,
                src.Length - (start + (end - start)));
            return dst;
        }

        /// <summary>
        /// Resizes the byte array to the specified size.
        /// </summary>
        /// <param name="src">The byte array to act on.</param>
        /// <param name="newSize">The new size of the byte array.</param>
        /// <returns>The resized byte array.</returns>
        public static byte[] Resize(this byte[] src, int newSize)
        {
            Array.Resize(ref src, newSize);
            return src;
        }

        #region ToBase64CharArray

        /// <summary>
        /// Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 
        /// digits. Parameters specify the subsets as offsets in the input and output arrays, and the number of elements in the input array to 
        /// convert.
        /// </summary>
        /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
        /// <param name="offsetIn">A position within inArray.</param>
        /// <param name="length">The number of elements of inArray to convert.</param>
        /// <param name="outArray">An output array of Unicode characters.</param>
        /// <param name="offsetOut">A position within outArray.</param>
        /// <returns>A 32-bit signed integer containing the number of bytes in outArray.</returns>
        public static int ToBase64CharArray(this byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
        {
            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut);
        }

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 
        /// digits. Parameters specify the subsets as offsets in the input and output arrays, the number of elements in the input array to 
        /// convert, and whether line breaks are inserted in the output array.
        /// </summary>
        /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
        /// <param name="offsetIn">A position within inArray.</param>
        /// <param name="length">The number of elements of inArray to convert.</param>
        /// <param name="outArray">An output array of Unicode characters.</param>
        /// <param name="offsetOut">A position within outArray.</param>
        /// <param name="options">InsertLineBreaks to insert a line break every 76 characters, or None to not insert line breaks.</param>
        /// <returns>A 32-bit signed integer containing the number of bytes in outArray.</returns>
        public static int ToBase64CharArray(this byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options)
        {
            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options);
        }

#endif

#endregion

        #region ToBase64String

        /// <summary>
        /// Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.
        /// </summary>
        /// <param name="inArray">An array of 8-bit unsigned integers.</param>
        /// <returns>The string representation, in base 64, of the contents of inArray.</returns>
        public static string ToBase64String(this byte[] inArray)
        {
            return Convert.ToBase64String(inArray);
        }

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. A 
        /// parameter specifies whether to insert line breaks in the return value.
        /// </summary>
        /// <param name="inArray">An array of 8-bit unsigned integers.</param>
        /// <param name="options">InsertLineBreaks to insert a line break every 76 characters, or None to not insert line breaks.</param>
        /// <returns>The string representation in base 64 of the elements in inArray.</returns>
        public static string ToBase64String(this byte[] inArray, Base64FormattingOptions options)
        {
            return Convert.ToBase64String(inArray, options);
        }

#endif

        /// <summary>
        /// Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.
        /// Parameters specify the subset as an offset in the input array, and the number of elements in the array to convert.
        /// </summary>
        /// <param name="inArray">An array of 8-bit unsigned integers.</param>
        /// <param name="offset">An offset in inArray.</param>
        /// <param name="length">The number of elements of inArray to convert.</param>
        /// <returns>The string representation in base 64 of length elements of inArray, starting at position offset.</returns>
        public static string ToBase64String(this byte[] inArray, int offset, int length)
        {
            return Convert.ToBase64String(inArray, offset, length);
        }

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. 
        /// Parameters specify the subset as an offset in the input array, the number of elements in the array to convert, and whether to insert 
        /// line breaks in the return value.
        /// </summary>
        /// <param name="inArray">An array of 8-bit unsigned integers.</param>
        /// <param name="offset">An offset in inArray.</param>
        /// <param name="length">The number of elements of inArray to convert.</param>
        /// <param name="options">InsertLineBreaks to insert a line break every 76 characters, or None to not insert line breaks.</param>
        /// <returns>The string representation in base 64 of length elements of inArray, starting at position offset.</returns>
        public static string ToBase64String(this byte[] inArray, int offset, int length, Base64FormattingOptions options)
        {
            return Convert.ToBase64String(inArray, offset, length, options);
        }

#endif

#endregion

        /// <summary>
        /// Converts the byte array to a memory stream.
        /// </summary>
        /// <param name="src">The byte array to act on.</param>
        /// <returns>The memory stream.</returns>
        public static MemoryStream ToMemoryStream(this byte[] src)
        {
            return new MemoryStream(src);
        }

#if !NETSTANDARD

        /// <summary>
        /// Encodes a byte array into its equivalent string representation using base 64 digits, which is usable for transmission on the URL.
        /// </summary>
        /// <param name="input">The byte array to encode.</param>
        /// <returns>The string containing the encoded token if the byte array length is greater than one; otherwise, an empty string ("").</returns>
        public static string UrlTokenEncode(this byte[] input)
        {
            return HttpServerUtility.UrlTokenEncode(input);
        }

#endif

        #region UrlDecode

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts a URL-encoded byte array into a decoded string using the specified decoding object.
        /// </summary>
        /// <param name="bytes">The array of bytes to decode.</param>
        /// <param name="e">The <see cref="Encoding"/> that specifies the decoding scheme.</param>
        /// <returns>A decoded string.</returns>
        public static string UrlDecode(this byte[] bytes, Encoding e)
        {
            return HttpUtility.UrlDecode(bytes, e);
        }

        /// <summary>
        /// Converts a URL-encoded byte array into a decoded string using the specified encoding object, starting at the specified position in 
        /// the array, and continuing for the specified number of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to decode.</param>
        /// <param name="offset">The position in the byte to begin decoding.</param>
        /// <param name="count">The number of bytes to decode.</param>
        /// <param name="e">The <see cref="Encoding"/> that specifies the decoding scheme.</param>
        /// <returns>A decoded string.</returns>
        public static string UrlDecode(this byte[] bytes, int offset, int count, Encoding e)
        {
            return HttpUtility.UrlDecode(bytes, offset, count, e);
        }

#endif

        #endregion

        #region UrlDecodeToBytes

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts a URL-encoded array of bytes into a decoded array of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to decode.</param>
        /// <returns>A decoded array of bytes.</returns>
        public static byte[] UrlDecodeToBytes(this byte[] bytes)
        {
            return HttpUtility.UrlDecodeToBytes(bytes);
        }

        /// <summary>
        /// Converts a URL-encoded array of bytes into a decoded array of bytes, starting at the specified position in the array and continuing 
        /// for the specified number of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to decode.</param>
        /// <param name="offset">The position in the byte array at which to begin decoding.</param>
        /// <param name="count">The number of bytes to decode.</param>
        /// <returns>A decoded array of bytes.</returns>
        public static byte[] UrlDecodeToBytes(this byte[] bytes, int offset, int count)
        {
            return HttpUtility.UrlDecodeToBytes(bytes, offset, count);
        }

#endif

        #endregion

        #region UrlEncode

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts a byte array into an encoded URL string.
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string UrlEncode(this byte[] bytes)
        {
            return HttpUtility.UrlEncode(bytes);
        }

        /// <summary>
        /// Converts a byte array into a URL-encoded string, starting at the specified position in the array and continuing for the specified 
        /// number of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <param name="offset">The position in the byte array at which to begin encoding.</param>
        /// <param name="count">The number of bytes to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string UrlEncode(this byte[] bytes, int offset, int count)
        {
            return HttpUtility.UrlEncode(bytes, offset, count);
        }

#endif

        #endregion

        #region UrlEncodeToBytes

#if !NETSTANDARD1_3

        /// <summary>
        /// Converts an array of bytes into a URL-encoded array of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <returns>An encoded array of bytes.</returns>
        public static byte[] UrlEncodeToBytes(this byte[] bytes)
        {
            return HttpUtility.UrlEncodeToBytes(bytes);
        }

        /// <summary>
        /// Converts an array of bytes into a URL-encoded array of bytes, starting at the specified position in the array and continuing for the 
        /// specified number of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <param name="offset">The position in the byte array at which to begin encoding.</param>
        /// <param name="count">The number of bytes to encode.</param>
        /// <returns>An encoded array of bytes.</returns>
        public static byte[] UrlEncodeToBytes(this byte[] bytes, int offset, int count)
        {
            return HttpUtility.UrlEncodeToBytes(bytes, offset, count);
        }

#endif

#endregion

#if !NETSTANDARD

        /// <summary>
        /// Converts the byte array to an image.
        /// </summary>
        /// <param name="src">The byte array to act on.</param>
        /// <returns>The image.</returns>
        public static Image ToImage(this byte[] src)
        {
            using (var memStream = new MemoryStream(src))
            {
                return Image.FromStream(memStream);
            }
        }

#endif

    }
}
