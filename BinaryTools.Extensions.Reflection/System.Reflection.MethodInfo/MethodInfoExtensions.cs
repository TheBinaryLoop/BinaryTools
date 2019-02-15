using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BinaryTools.Extensions.Reflection
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="MethodInfo"/> class.
    /// </summary>
    public static partial class MethodInfoExtensions
    {

#if NETSTANDARD2_0_OR_GREATER || NETFULL

        /// <summary>
        /// Gets the declaration of the current MethodInfo.
        /// </summary>
        /// <param name="methodInfo">The MethodInfo to act on.</param>
        /// <returns>The declaration.</returns>
        public static string GetDeclaration(this MethodInfo methodInfo)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
            StringBuilder sb = new StringBuilder();

            // Visibility
            if (methodInfo.IsPublic)
            {
                sb.Append("public ");
            }
            else if (methodInfo.IsFamily)
            {
                sb.Append("protected ");
            }
            else if (methodInfo.IsAssembly)
            {
                sb.Append("internal ");
            }
            else if (methodInfo.IsPrivate)
            {
                sb.Append("private ");
            }
            else
            {
                sb.Append("protected internal ");
            }

            // Modifier
            if (methodInfo.IsAbstract)
            {
                sb.Append("abstract ");
            }
            else if (methodInfo.GetBaseDefinition().DeclaringType != methodInfo.DeclaringType)
            {
                sb.Append("override ");
            }
            else if (methodInfo.IsVirtual)
            {
                sb.Append("virtual ");
            }
            else if (methodInfo.IsStatic)
            {
                sb.Append("static ");
            }

            // Type
            sb.Append(methodInfo.ReturnType.GetShortDeclaration());
            sb.Append(" ");

            // Name
            sb.Append(methodInfo.Name);

            if (methodInfo.IsGenericMethod)
            {
                sb.Append("<");

                Type[] arguments = methodInfo.GetGenericArguments();

                sb.Append(string.Join(", ", arguments.Select(x => x.GetShortDeclaration()).ToArray()));

                sb.Append(">");
            }

            // Parameters
            ParameterInfo[] parameters = methodInfo.GetParameters();
            sb.Append("(");
            sb.Append(string.Join(", ", parameters.Select(p => p.GetDeclaration()).ToArray()));
            sb.Append(")");

            return sb.ToString();
        }

        /// <summary>
        /// Gets the signature of the current MethodInfo.
        /// </summary>
        /// <param name="methodInfo">The MethodInfo to act on.</param>
        /// <returns>The signature.</returns>
        public static string GetSignature(this MethodInfo methodInfo)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
            var sb = new StringBuilder();

            // Name
            sb.Append(methodInfo.Name);

            if (methodInfo.IsGenericMethod)
            {
                sb.Append("<");

                Type[] arguments = methodInfo.GetGenericArguments();

                sb.Append(string.Join(", ", arguments.Select(p => p.GetShortSignature()).ToArray()));

                sb.Append(">");
            }

            // Parameters
            ParameterInfo[] parameters = methodInfo.GetParameters();
            sb.Append("(");
            sb.Append(string.Join(", ", parameters.Select(p => p.GetSignature()).ToArray()));
            sb.Append(")");

            return sb.ToString();
        }

#endif

    }
}
