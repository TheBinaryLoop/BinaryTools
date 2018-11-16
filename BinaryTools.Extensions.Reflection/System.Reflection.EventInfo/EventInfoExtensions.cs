using System;
using System.Reflection;

namespace BinaryTools.Extensions.Reflection
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="EventInfo"/> class.
    /// </summary>
    public static partial class EventInfoExtensions
    {
        /// <summary>
        /// [NotImplemented]
        /// Gets the declaration of the current EventInfo.
        /// </summary>
        /// <param name="eventInfo">The EventInfo to act on.</param>
        /// <returns>The declaration.</returns>
        public static string GetDeclaration(this EventInfo eventInfo)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        /// <summary>
        /// [NotImplemented]
        /// Gets the signature of the current EventInfo.
        /// </summary>
        /// <param name="eventInfo">The EventInfo to act on.</param>
        /// <returns>The signature.</returns>
        public static string GetSignature(this EventInfo eventInfo)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

    }
}
