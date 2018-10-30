using System;

namespace BinaryTools.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Array"/> class.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Sets a range of elements in the array to zero, to false, or to null, depending on the element type.
        /// </summary>
        /// <param name="array">The array whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range of elements to clear.</param>
        /// <param name="length">The number of elements to clear.</param>
        public static void Clear(this Array array, Int32 index, Int32 length)
        {
            Array.Clear(array, index, length);
        }

        /// <summary>
        /// Clears the array.
        /// </summary>
        /// <param name="array">The array to act on.</param>
        public static void ClearAll(this Array array)
        {
            Array.Clear(array, 0, array.Length);
        }

        /// <summary>
        /// Checks if the array is lower then the specified index.
        /// </summary>
        /// <param name="array">The array to act on.</param>
        /// <param name="index">Zero-based index of the array.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool WithinIndex(this Array array, int index)
        {
            return index >= 0 && index < array.Length;
        }

        /// <summary>
        /// Checks if the array is lower then the specified index.
        /// </summary>
        /// <param name="array">The array to act on.</param>
        /// <param name="index">Zero-based index of the array.</param>
        /// <param name="dimension">(Optional) the dimension.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool WithinIndex(this Array array, int index, int dimension = 0)
        {
            return index >= array.GetLowerBound(dimension) && index <= array.GetUpperBound(dimension);
        }


    }
}
