using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace BinaryTools.Extensions.Reflection
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="FieldInfo"/> class.
    /// </summary>
    public static partial class FieldInfoExtensions
    {

        /// <summary>
        /// Gets the declaration of the current FieldInfo.
        /// </summary>
        /// <param name="fieldInfo">The FieldInfo to act on.</param>
        /// <returns>The declaration.</returns>
        public static string GetDeclaration(this FieldInfo fieldInfo)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [PostModifier];
            StringBuilder sb = new StringBuilder();

            // Variable
            bool isConstant = false;
            Type[] requiredTypes = fieldInfo.GetRequiredCustomModifiers();

            // Visibility
            if (fieldInfo.IsPublic)
            {
                sb.Append("public ");
            }
            else if (fieldInfo.IsPrivate)
            {
                sb.Append("private ");
            }
            else if (fieldInfo.IsFamily)
            {
                sb.Append("protected ");
            }
            else if (fieldInfo.IsAssembly)
            {
                sb.Append("internal ");
            }
            else
            {
                sb.Append("protected internal ");
            }

            // Modifier
            if (fieldInfo.IsStatic)
            {
                if (fieldInfo.IsLiteral)
                {
                    isConstant = true;
                    sb.Append("const ");
                }
                else
                {
                    sb.Append("static ");
                }
            }
            else if (fieldInfo.IsInitOnly)
            {
                sb.Append("readonly ");
            }
            if (requiredTypes.Any(x => x == typeof(IsVolatile)))
            {
                sb.Append("volatile ");
            }

            // Type
            sb.Append(fieldInfo.FieldType.GetShortDeclaration());
            sb.Append(" ");

            // Name
            sb.Append(fieldInfo.Name);

            // PostModifier
            if (isConstant)
            {
                sb.Append(" = " + fieldInfo.GetRawConstantValue());
            }

            // End
            sb.Append(";");

            return sb.ToString();
        }

        /// <summary>
        /// Gets the signature of the current FieldInfo.
        /// </summary>
        /// <param name="fieldInfo">The FieldInfo to act on.</param>
        /// <returns>The signature.</returns>
        public static string GetSignature(this FieldInfo fieldInfo)
        {
            return fieldInfo.Name;
        }

    }
}
