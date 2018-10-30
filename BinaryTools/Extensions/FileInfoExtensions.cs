using System.IO;
using System.IO.Compression;

namespace BinaryTools.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="FileInfo"/> class.
    /// </summary>
    public static class FileInfoExtensions
    {
        /// <summary>
        /// Creates a .gz file.
        /// </summary>
        /// <param name="fileInfo">The FileInfo to act on.</param>
        public static void CreateGZip(this FileInfo fileInfo)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create($"{fileInfo.FullName}.gz"))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        /// Creates a .gz file.
        /// </summary>
        /// <param name="fileInfo">The FileInfo to act on.</param>
        /// <param name="destination">The destination file with filename.</param>
        public static void CreateGZip(this FileInfo fileInfo, string destination)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        /// Creates a .gz file.
        /// </summary>
        /// <param name="fileInfo">The FileInfo to act on.</param>
        /// <param name="destination">The destination FileInfo object.</param>
        public static void CreateGZip(this FileInfo fileInfo, FileInfo destination)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination.FullName))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        /// Extracts a .gz file into a directory with the same name.
        /// </summary>
        /// <param name="fileInfo">The FileInfo to act on.</param>
        public static void ExtractGZipToDirectory(this FileInfo fileInfo)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                string newFileName = Path.GetFileNameWithoutExtension(fileInfo.FullName);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        /// <summary>
        /// Extracts a .gz file into the specified directory.
        /// </summary>
        /// <param name="fileInfo">The FileInfo to act on.</param>
        /// <param name="destination">Destination directory.</param>
        public static void ExtractGZipToDirectory(this FileInfo fileInfo, string destination)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream decompressedFileStream = File.Create(destination))
                {
                    using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        /// <summary>
        /// Extracts a .gz file into the specified directory.
        /// </summary>
        /// <param name="fileInfo">The FileInfo to act on.</param>
        /// <param name="destination">Destination directory.</param>
        public static void ExtractGZipToDirectory(this FileInfo fileInfo, FileInfo destination)
        {
            using (FileStream originalFileStream = fileInfo.OpenRead())
            {
                using (FileStream decompressedFileStream = File.Create(destination.FullName))
                {
                    using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }
    }
}
