using System.Collections.Generic;

namespace BinaryTools.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="List{T}"/> class.
    /// </summary>
    public static class ListExtensions
    {
        public static T Pop<T>(this List<T> list)
        {
            T f = list[0];
            list.Remove(f);
            return f;
        }
        public static void Push<T>(this List<T> list, T item)
        {
            list.Add(item);
        }
    }
}
