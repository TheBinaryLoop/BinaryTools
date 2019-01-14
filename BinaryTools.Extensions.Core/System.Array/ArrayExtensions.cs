using System;
using System.Collections;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Array"/> class.
    /// </summary>
    public static partial class ArrayExtensions
    {
        #region BinarySearch

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
        public static int BinarySearch(this Array array, Object value)
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
        public static int BinarySearch(this Array array, int index, int length, Object value)
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
        public static int BinarySearch(this Array array, Object value, IComparer comparer)
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
        public static int BinarySearch(this Array array, int index, int length, Object value, IComparer comparer)
        {
            return Array.BinarySearch(array, index, length, value, comparer);
        }

        #endregion

        /// <summary>
        /// Sets a range of elements in the array to zero, to false, or to null, depending on the element type.
        /// </summary>
        /// <param name="array">The array whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range of elements to clear.</param>
        /// <param name="length">The number of elements to clear.</param>
        public static void Clear(this Array array, int index, int length)
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
        /// Copies a range of elements from an <see cref="Array"/> starting at the specified source index and pastes them to another <see cref="Array"/> starting at the 
        /// specified destination index. Guarantees that all changes are undone if the copy does not succeed completely.
        /// </summary>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the sourceArray at which copying begins.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the destinationArray at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void ConstrainedCopy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
        {
            Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        #region Copy

        /// <summary>
        /// Copies a range of elements from an <see cref="Array"/> starting at the first element and pastes them into another <see cref="Array"/> starting at the first
        /// element. The length is specified as a 32-bit integer.
        /// </summary>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void Copy(this Array sourceArray, Array destinationArray, int length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }

        /// <summary>
        /// Copies a range of elements from an <see cref="Array"/> starting at the specified source index and pastes them to another <see cref="Array"/> starting at the
        /// specified destination index. The length and the indexes are specified as 32-bit integers.
        /// </summary>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void Copy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

#if !NETSTANDARD1_3

        /// <summary>
        /// Copies a range of elements from an <see cref="Array"/> starting at the first element and pastes them into another <see cref="Array"/> starting at the first
        /// element. The length is specified as a 64-bit integer.
        /// </summary>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="length">
        /// A 64-bit integer that represents the number of elements to copy. The integer must be between zero and <see cref="Int32.MaxValue"/>, inclusive.
        /// </param>
        public static void Copy(this Array sourceArray, Array destinationArray, Int64 length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }


        /// <summary>
        /// Copies a range of elements from an <see cref="Array"/> starting at the specified source index and pastes them to another <see cref="Array"/> starting at the
        /// specified destination index. The length and the indexes are specified as 64-bit integers.
        /// </summary>
        /// <param name="sourceArray">The <see cref="Array"/> that contains the data to copy.</param>
        /// <param name="sourceIndex">A 64-bit integer that represents the index in the sourceArray at which copying begins.</param>
        /// <param name="destinationArray">The <see cref="Array"/> that receives the data.</param>
        /// <param name="destinationIndex">A 64-bit integer that represents the index in the destinationArray at which storing begins.</param>
        /// <param name="length">
        /// A 64-bit integer that represents the number of elements to copy. The integer must be between zero and <see cref="Int32.MaxValue"/>, inclusive.
        /// </param>
        public static void Copy(this Array sourceArray, Int64 sourceIndex, Array destinationArray, Int64 destinationIndex, Int64 length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

#endif

        #endregion

        #region IndexOf

        /// <summary>
        /// Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.
        /// </summary>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in array.</param>
        /// <returns>The index of the first occurrence of value in array, if found; otherwise, the lower bound of the array minus 1.</returns>
        public static int IndexOf(this Array array, Object value)
        {
            return Array.IndexOf(array, value);
        }

        /// <summary>
        /// Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. 
        /// The range extends from a specified index to the end of the array.
        /// </summary>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in array.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <returns>
        /// The index of the first occurrence of value, if it’s found, within the range of elements in array that extends from startIndex to 
        /// the last element; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static int IndexOf(this Array array, Object value, int startIndex)
        {
            return Array.IndexOf(array, value, startIndex);
        }

        /// <summary>
        /// Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs first occurrence. 
        /// The range extends from a specified index for a specified number of elements.
        /// </summary>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in array.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <param name="count">The number of elements to search.</param>
        /// <returns>
        /// The index of the first occurrence of value, if it’s found in the array from index startIndex to startIndex + count - 1; 
        /// otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static int IndexOf(this Array array, Object value, int startIndex, int count)
        {
            return Array.IndexOf(array, value, startIndex, count);
        }

        #endregion

        #region LastIndexOf

        /// <summary>
        /// Searches for the specified object and returns the index of the last occurrence within the entire one-dimensional <see cref="Array"/>.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="value">The object to locate in array.</param>
        /// <returns>
        /// The index of the last occurrence of value within the entire array, if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static int LastIndexOf(this Array array, Object value)
        {
            return Array.LastIndexOf(array, value);
        }

        /// <summary>
        /// Searches for the specified object and returns the index of the last occurrence within the range of elements in the one-dimensional 
        /// <see cref="Array"/> that extends from the first element to the specified index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="value">The object to locate in array.</param>
        /// <param name="startIndex">The starting index of the backward search.</param>
        /// <returns>
        /// The index of the last occurrence of value within the range of elements in array that extends from the first element to 
        /// startIndex, if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static int LastIndexOf(this Array array, Object value, int startIndex)
        {
            return Array.LastIndexOf(array, value, startIndex);
        }

        /// <summary>
        /// Searches for the specified object and returns the index of the last occurrence within the range of elements in the one-dimensional 
        /// <see cref="Array"/> that contains the specified number of elements and ends at the specified index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to search.</param>
        /// <param name="value">The object to locate in array.</param>
        /// <param name="startIndex">The starting index of the backward search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>
        /// The index of the last occurrence of value within the range of elements in array that contains the number of elements specified 
        /// in count and ends at startIndex, if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static int LastIndexOf(this Array array, Object value, int startIndex, int count)
        {
            return Array.LastIndexOf(array, value, startIndex, count);
        }

        #endregion

        #region Reverse

        /// <summary>
        /// Reverses the sequence of the elements in the entire one-dimensional <see cref="Array"/>.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to reverse.</param>
        public static void Reverse(this Array array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Reverses the sequence of the elements in a range of elements in the one-dimensional <see cref="Array"/>.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to reverse.</param>
        /// <param name="index">The starting index of the section to reverse.</param>
        /// <param name="length">The number of elements in the section to reverse.</param>
        public static void Reverse(this Array array, int index, int length)
        {
            Array.Reverse(array, index, length);
        }

        #endregion

        #region Sort

        /// <summary>
        /// Sorts the elements in an entire one-dimensional <see cref="Array"/> using the <see cref="IComparable"/> implementation of each element of the <see cref="Array"/>.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        public static void Sort(this Array array)
        {
            Array.Sort(array);
        }

        /// <summary>
        /// Sorts a pair of one-dimensional <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on 
        /// the keys in the first <see cref="Array"/> using the <see cref="IComparable"/> implementation of each key.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <param name="items">
        /// The one-dimensional <see cref="Array"/> that contains the items that correspond to each of the keys in the keys<see cref="Array"/>.
        /// -or-
        /// null to sort only the keysArray.
        /// </param>
        public static void Sort(this Array array, Array items)
        {
            Array.Sort(array, items);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in a one-dimensional <see cref="Array"/> using the <see cref="IComparable"/> implementation of each element of the <see cref="Array"/>.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        public static void Sort(this Array array, int index, int length)
        {
            Array.Sort(array, index, length);
        }

        /// <summary>
        /// Sorts a range of elements in a pair of one-dimensional <see cref="Array"/> objects (one contains the keys and the other contains the 
        /// corresponding items) based on the keys in the first <see cref="Array"/> using the <see cref="IComparable"/> implementation of each key.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <param name="items">
        /// The one-dimensional <see cref="Array"/> that contains the items that correspond to each of the keys in the keys<see cref="Array"/>.
        /// -or-
        /// null to sort only the keysArray.
        /// </param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        public static void Sort(this Array array, Array items, int index, int length)
        {
            Array.Sort(array, items, index, length);
        }

        /// <summary>
        /// Sorts the elements in a one-dimensional <see cref="Array"/> using the specified <see cref="IComparer"/>.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <param name="comparer">
        /// The implementation to use when comparing elements. 
        /// -or-
        /// null to use the <see cref="IComparable"/> implementation of each element.
        /// </param>
        public static void Sort(this Array array, IComparer comparer)
        {
            Array.Sort(array, comparer);
        }

        /// <summary>
        /// Sorts a pair of one-dimensional <see cref="Array"/> objects (one contains the keys and the other contains the corresponding items) based on 
        /// the keys in the first <see cref="Array"/> using the specified <see cref="IComparer"/>.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <param name="items">
        /// The one-dimensional <see cref="Array"/> that contains the items that correspond to each of the keys in the keys<see cref="Array"/>.
        /// -or-
        /// null to sort only the keysArray.
        /// </param>
        /// <param name="comparer">
        /// The <see cref="IComparer"/> implementation to use when comparing elements. 
        /// -or-
        /// null to use the <see cref="IComparable"/> implementation of each element.
        /// </param>
        public static void Sort(this Array array, Array items, IComparer comparer)
        {
            Array.Sort(array, items, comparer);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in a one-dimensional <see cref="Array"/> using the specified <see cref="IComparer"/>.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <param name="comparer">
        /// The <see cref="IComparer"/> implementation to use when comparing elements. 
        /// -or-
        /// null to use the <see cref="IComparable"/> implementation of each element.
        /// </param>
        public static void Sort(this Array array, int index, int length, IComparer comparer)
        {
            Array.Sort(array, index, length, comparer);
        }

        /// <summary>
        /// Sorts a range of elements in a pair of one-dimensional <see cref="Array"/> objects (one contains the keys and the other contains the 
        /// corresponding items) based on the keys in the first <see cref="Array"/> using the specified <see cref="IComparer"/>.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> to sort.</param>
        /// <param name="items">
        /// The one-dimensional <see cref="Array"/> that contains the items that correspond to each of the keys in the keys<see cref="Array"/>.
        /// -or-
        /// null to sort only the keysArray.
        /// </param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <param name="comparer">
        /// The <see cref="IComparer"/> implementation to use when comparing elements. 
        /// -or-
        /// null to use the <see cref="IComparable"/> implementation of each element.
        /// </param>
        public static void Sort(this Array array, Array items, int index, int length, IComparer comparer)
        {
            Array.Sort(array, items, index, length, comparer);
        }

        #endregion

        #region WithinIndex

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

        #endregion

    }
}
