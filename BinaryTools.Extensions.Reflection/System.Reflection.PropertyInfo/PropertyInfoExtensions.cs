using System.Linq;
using System.Reflection;
using System.Text;

namespace BinaryTools.Extensions.Reflection
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="PropertyInfo"/> class.
    /// </summary>
    public static partial class PropertyInfoExtensions
    {

#if NETSTANDARD2_0_OR_GREATER || NETFULL

        /// <summary>
        /// Gets the declaration of the current PropertyInfo.
        /// </summary>
        /// <param name="propertyInfo">The PropertyInfo to act on.</param>
        /// <returns>The declaration.</returns>
        public static string GetDeclaration(this PropertyInfo propertyInfo)
        {
            // Example: [Visibility] [Modifier] [Type] [Name | Indexer] { [VisibilityGetter] [Getter]; [VisibilitySetter] [Setter]; }
            StringBuilder sb = new StringBuilder();

            // Variable
            bool canRead = propertyInfo.CanRead;
            bool canWrite = propertyInfo.CanWrite;
            int readLevel = 9;
            int writeLevel = 9;
            string readVisibility = "";
            string writeVisibility = "";

            // Variable Method
            bool isAbstract = false;
            bool isOverride = false;
            bool isStatic = false;
            bool isVirtual = false;

            // Set visibility
            if (canRead)
            {
                MethodInfo method = propertyInfo.GetGetMethod(true);
                isAbstract = method.IsAbstract;
                isOverride = method.GetBaseDefinition().DeclaringType != method.DeclaringType;
                isStatic = method.IsStatic;
                isVirtual = method.IsVirtual;

                if (method.IsPublic)
                {
                    readLevel = 1;
                    readVisibility = "public ";
                }
                else if (method.IsFamily)
                {
                    readLevel = 2;
                    readVisibility = "protected ";
                }
                else if (method.IsAssembly)
                {
                    readLevel = 3;
                    readVisibility = "internal ";
                }
                else if (method.IsPrivate)
                {
                    readLevel = 5;
                    readVisibility = "private ";
                }
                else
                {
                    readLevel = 4;
                    readVisibility = "protected internal ";
                }
            }
            if (canWrite)
            {
                MethodInfo method = propertyInfo.GetSetMethod(true);

                if (readLevel != 9)
                {
                    isAbstract = method.IsAbstract;
                    isOverride = method.GetBaseDefinition().DeclaringType != method.DeclaringType;
                    isStatic = method.IsStatic;
                    isVirtual = method.IsVirtual;
                }

                if (method.IsPublic)
                {
                    writeLevel = 1;
                    writeVisibility = "public ";
                }
                else if (method.IsFamily)
                {
                    writeLevel = 2;
                    writeVisibility = "protected ";
                }
                else if (method.IsAssembly)
                {
                    writeLevel = 3;
                    writeVisibility = "internal ";
                }
                else if (method.IsPrivate)
                {
                    writeLevel = 5;
                    writeVisibility = "private ";
                }
                else
                {
                    writeLevel = 4;
                    writeVisibility = "protected internal ";
                }
            }

            // Visibility
            if (canRead && canWrite)
            {
                sb.Append(readLevel <= writeLevel ? readVisibility : writeVisibility);
            }
            else if (canRead)
            {
                sb.Append(readVisibility);
            }
            else
            {
                sb.Append(writeVisibility);
            }

            // Modifier
            if (isAbstract)
            {
                sb.Append("abstract ");
            }
            else if (isOverride)
            {
                sb.Append("override ");
            }
            else if (isVirtual)
            {
                sb.Append("virtual ");
            }
            else if (isStatic)
            {
                sb.Append("static ");
            }

            // Type
            sb.Append(propertyInfo.PropertyType.GetShortDeclaration());
            sb.Append(" ");

            // [Name | Indexer]
            ParameterInfo[] indexerParameter = propertyInfo.GetIndexParameters();
            if (indexerParameter.Length == 0)
            {
                // Name
                sb.Append(propertyInfo.Name);
            }
            else
            {
                // Indexer
                sb.Append("this");
                sb.Append("[");
                sb.Append(string.Join(", ", indexerParameter.Select(p => p.ParameterType.GetShortDeclaration() + " " + p.Name).ToArray()));
                sb.Append("]");
            }
            sb.Append(" ");

            sb.Append("{ ");
            // Getter
            if (propertyInfo.CanRead)
            {
                if (readLevel > writeLevel)
                {
                    sb.Append(readVisibility);
                }
                sb.Append("get; ");
            }

            // Setter
            if (propertyInfo.CanWrite)
            {
                if (writeLevel > readLevel)
                {
                    sb.Append(writeVisibility);
                }
                sb.Append("set; ");
            }
            sb.Append("}");

            return sb.ToString();
        }

#endif

        /// <summary>
        /// Gets the signature of the current PropertyInfo.
        /// </summary>
        /// <param name="propertyInfo">The PropertyInfo to act on.</param>
        /// <returns>The signature.</returns>
        public static string GetSignature(this PropertyInfo propertyInfo)
        {
            // Example: [Name | Indexer[Type]]

            var indexerParameter = propertyInfo.GetIndexParameters();
            if (indexerParameter.Length == 0)
            {
                // Name
                return propertyInfo.Name;
            }
            var sb = new StringBuilder();

            // Indexer
            sb.Append(propertyInfo.Name);
            sb.Append("[");
            sb.Append(string.Join(", ", indexerParameter.Select(p => p.ParameterType.GetShortSignature()).ToArray()));
            sb.Append("]");

            return sb.ToString();
        }

    }
}
