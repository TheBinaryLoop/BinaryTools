using System.Linq;
using System.Reflection;
using System.Text;

namespace BinaryTools.Extensions.Reflection
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="ConstructorInfo"/> class.
    /// </summary>
    public static partial class ConstructorInfoExtensions
    {

        /// <summary>
        /// Gets the declaration of the current ConstructorInfo.
        /// </summary>
        /// <param name="constructorInfo">The ConstructorInfo to act on.</param>
        /// <returns>The declaration.</returns>
        public static string GetDeclaration(this ConstructorInfo constructorInfo)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
            StringBuilder sb = new StringBuilder();

            // Visibility
            if (constructorInfo.IsPublic)
            {
                sb.Append("public ");
            }
            else if (constructorInfo.IsFamily)
            {
                sb.Append("protected ");
            }
            else if (constructorInfo.IsAssembly)
            {
                sb.Append("internal ");
            }
            else if (constructorInfo.IsPrivate)
            {
                sb.Append("private ");
            }
            else
            {
                sb.Append("protected internal ");
            }

            // Name
            sb.Append(constructorInfo.ReflectedType.IsGenericType ? constructorInfo.ReflectedType.Name.Substring(0, constructorInfo.ReflectedType.Name.IndexOf('`')) : constructorInfo.ReflectedType.Name);

            // Parameters
            ParameterInfo[] parameters = constructorInfo.GetParameters();
            sb.Append("(");
            sb.Append(string.Join(", ", parameters.Select(p => p.GetDeclaration())));
            sb.Append(")");

            return sb.ToString();
        }

        /// <summary>
        /// Gets the signature of the current ConstructorInfo.
        /// </summary>
        /// <param name="constructorInfo">The ConstructorInfo to act on.</param>
        /// <returns>The signature.</returns>
        public static string GetSignature(this ConstructorInfo constructorInfo)
        {
            // Example:  [Name] [<GenericArguments] ([Parameters])
            var sb = new StringBuilder();

            // Name
            sb.Append(constructorInfo.ReflectedType.IsGenericType ? constructorInfo.ReflectedType.Name.Substring(0, constructorInfo.ReflectedType.Name.IndexOf('`')) : constructorInfo.ReflectedType.Name);

            // Parameters
            ParameterInfo[] parameters = constructorInfo.GetParameters();
            sb.Append("(");
            sb.Append(string.Join(", ", parameters.Select(p => p.GetSignature())));
            sb.Append(")");

            return sb.ToString();
        }

    }
}
