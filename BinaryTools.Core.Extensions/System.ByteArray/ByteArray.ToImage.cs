#if !NETSTANDARD
using System;
using System.Drawing;
using System.IO;

namespace BinaryTools.Core.Extensions
{
    public static partial class ByteArrayExtensions
    {
        /// <summary>
        /// Converts the byte array to an image.
        /// </summary>
        /// <param name="src">The byte array to act on.</param>
        /// <returns>The image.</returns>
        public static Image ToImage(this Byte[] src)
        {
            using (var memStream = new MemoryStream(src))
            {
                return Image.FromStream(memStream);
            }
        }
    }
}
#endif
