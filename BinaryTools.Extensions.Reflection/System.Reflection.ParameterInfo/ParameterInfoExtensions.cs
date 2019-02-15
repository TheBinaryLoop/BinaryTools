using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace BinaryTools.Extensions.Reflection
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="ParameterInfo"/> class.
    /// </summary>
    public static partial class ParameterInfoExtensions
    {

#if NETSTANDARD2_0_OR_GREATER || NETFULL

        /// <summary>
        /// Gets the declaration of the current ParameterInfo.
        /// </summary>
        /// <param name="parameterInfo">The ParameterInfo to act on.</param>
        /// <returns>The declaration.</returns>
        public static string GetDeclaration(this ParameterInfo parameterInfo)
        {
            StringBuilder sb = new StringBuilder();
            parameterInfo.GetDeclaration(sb);
            return sb.ToString();
        }

        /// <summary>
        /// Gets the declaration of the current ParameterInfo and puts it into the specified StringBuilder.
        /// </summary>
        /// <param name="parameterInfo">The ParameterInfo to act on.</param>
        /// <param name="stringBuilder">The StringBuilder to use.</param>
        public static void GetDeclaration(this ParameterInfo parameterInfo, StringBuilder stringBuilder)
        {
            List<string> attributes = new List<string>();

            string typeName;
            Type elementType = parameterInfo.ParameterType.GetElementType();

            if (elementType != null)
            {
                typeName = parameterInfo.ParameterType.Name.Replace(elementType.Name, elementType.GetShortDeclaration());
            }
            else
            {
                typeName = parameterInfo.ParameterType.GetShortDeclaration();
            }

            if (Attribute.IsDefined(parameterInfo, typeof(ParamArrayAttribute)))
            {
                stringBuilder.Append("params ");
            }
            else if (parameterInfo.Position == 0 && parameterInfo.Member.IsDefined(typeof(ExtensionAttribute)))
            {
                stringBuilder.Append("this ");
            }

            if (parameterInfo.IsIn)
            {
                attributes.Add("In");
            }

            if (parameterInfo.IsOut)
            {
                if (typeName.Contains("&"))
                {
                    typeName = typeName.Replace("&", "");
                    stringBuilder.Append("out ");
                }
                else
                {
                    attributes.Add("Out");
                }
            }
            else if (parameterInfo.ParameterType.IsByRef)
            {
                typeName = typeName.Replace("&", "");
                stringBuilder.Append("ref ");
            }
            stringBuilder.Append(typeName);

            stringBuilder.Append(" ");
            stringBuilder.Append(parameterInfo.Name);

            if (parameterInfo.IsOptional)
            {
                if (parameterInfo.DefaultValue != Missing.Value)
                {
                    stringBuilder.Append(" = " + parameterInfo.DefaultValue);
                }
                else
                {
                    attributes.Add("Optional");
                }
            }

            string attribute = attributes.Count > 0 ? "[" + string.Join(", ", attributes.ToArray()) + "] " : "";
            stringBuilder.Insert(0, attribute);
        }

#endif

        /// <summary>
        /// Gets the signature of the current ParameterInfo.
        /// </summary>
        /// <param name="parameterInfo">The ParameterInfo to act on.</param>
        /// <returns>The signature.</returns>
        public static string GetSignature(this ParameterInfo parameterInfo)
        {
            var sb = new StringBuilder();

            parameterInfo.GetSignature(sb);
            return sb.ToString();
        }

        /// <summary>
        /// Gets the signature of the current ParameterInfo and puts it into the specified StringBuilder.
        /// </summary>
        /// <param name="parameterInfo">The ParameterInfo to act on.</param>
        /// <param name="stringBuilder">The StringBuilder to use.</param>
        public static void GetSignature(this ParameterInfo parameterInfo, StringBuilder stringBuilder)
        {
            // retval attribute
            string typeName;
            Type elementType = parameterInfo.ParameterType.GetElementType();

            if (elementType != null)
            {
                typeName = parameterInfo.ParameterType.Name.Replace(elementType.Name, elementType.GetShortSignature());
            }
            else
            {
                typeName = parameterInfo.ParameterType.GetShortSignature();
            }

            if (parameterInfo.IsOut)
            {
                if (typeName.Contains("&"))
                {
                    typeName = typeName.Replace("&", "");
                    stringBuilder.Append("out ");
                }
            }
            else if (parameterInfo.ParameterType.IsByRef)
            {
                typeName = typeName.Replace("&", "");
                stringBuilder.Append("ref ");
            }
            stringBuilder.Append(typeName);
        }

    }
}
