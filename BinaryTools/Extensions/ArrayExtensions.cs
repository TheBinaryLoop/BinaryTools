using System;
using System.Collections;

namespace BinaryTools.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Array"/> class.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Searches an entire one-dimensional sorted array for a specific element, using the <see cref="IComparable"/> interface
        /// implemented by each element of the array and by the specified object.
        /// </summary>
        /// <param name="array">The sorted one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>
        /// The index of the specified value in the specified array, if value is found; otherwise, a negative number. If value is not found 
        /// and value is less than one or more elements in array, the negative number returned is the bitwise complement of the index of
        /// the first element that is larger than value. If value is not found and value is greater than all elements in array, the negative
        /// number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted 
        /// array, the return value can be incorrect and a negative number could be returned, even if value is present in array.
        /// </returns>
        public static Int32 BinarySearch(this Array array, Object value)
        {
            return Array.BinarySearch(array, value);
        }

        /// <summary>
        /// Searches a range of elements in a one-dimensional sorted array for a value, using the <see cref="IComparable"/> interface
        /// implemented by each element of the array and by the specified value.
        /// </summary>
        /// <param name="array">The sorted one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>
        /// The index of the specified value in the specified array, if value is found; otherwise, a negative number. If value is not found 
        /// and value is less than one or more elements in array, the negative number returned is the bitwise complement of the index of 
        /// the first element that is larger than value. If value is not found and value is greater than all elements in array, the negative 
        /// number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted 
        /// array, the return value can be incorrect and a negative number could be returned, even if value is present in array.
        /// </returns>
        public static Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value)
        {
            return Array.BinarySearch(array, index, length, value);
        }

        /// <summary>
        /// Searches an entire one-dimensional sorted array for a value using the specified <see cref="IComparable"/> interface.
        /// </summary>
        /// <param name="array">The sorted one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">
        /// The <see cref="IComparable"/> implementation to use when comparing elements. 
        /// -or-
        /// null to use the <see cref="IComparable"/> implementation of each element.
        /// </param>
        /// <returns>
        /// The index of the specified value in the specified array, if value is found; otherwise, a negative number. If value is not found
        /// and value is less than one or more elements in array, the negative number returned is the bitwise complement of the index of
        /// the first element that is larger than value. If value is not found and value is greater than all elements in array, the negative 
        /// number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted 
        /// array, the return value can be incorrect and a negative number could be returned, even if value is present in array.
        /// </returns>
        public static Int32 BinarySearch(this Array array, Object value, IComparer comparer)
        {
            return Array.BinarySearch(array, value, comparer);
        }

        /// <summary>
        /// Searches a range of elements in a one-dimensional sorted array for a value, using the specified <see cref="IComparable"/> interface.
        /// </summary>
        /// <param name="array">The sorted one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">
        /// The <see cref="IComparable"/> implementation to use when comparing elements. 
        /// -or-
        /// null to use the <see cref="IComparable"/> implementation of each element.
        /// </param>
        /// <returns>
        /// The index of the specified value in the specified array, if value is found; otherwise, a negative number. If value is not found
        /// and value is less than one or more elements in array, the negative number returned is the bitwise complement of the index of
        /// the first element that is larger than value. If value is not found and value is greater than all elements in array, the negative 
        /// number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted 
        /// array, the return value can be incorrect and a negative number could be returned, even if value is present in array.
        /// </returns>
        public static Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value, IComparer comparer)
        {
            return Array.BinarySearch(array, index, length, value, comparer);
        }

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
