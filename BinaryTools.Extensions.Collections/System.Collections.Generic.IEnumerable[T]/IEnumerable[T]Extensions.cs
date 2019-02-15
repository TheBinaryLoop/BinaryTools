using System.Collections.Generic;
using System.Linq;

namespace BinaryTools.Extensions.Collections
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="IEnumerable{T}"/> class.
    /// </summary>
    public static partial class IEnumerable_T_Extensions
    {

        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> ts, int chunkSize)
        {
            while (ts.Any())
            {
                yield return ts.Take(chunkSize);
                ts = ts.Skip(chunkSize);
            }
        }

    }
}
