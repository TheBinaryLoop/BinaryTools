using System.Collections.Generic;

namespace BinaryTools.Extensions
{
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
