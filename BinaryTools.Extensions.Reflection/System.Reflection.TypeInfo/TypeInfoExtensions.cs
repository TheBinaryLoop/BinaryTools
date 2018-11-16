using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BinaryTools.Extensions.Reflection
{

    /// <summary>
    /// A collection of helpful extension methods for the <see cref="TypeInfo"/> class.
    /// </summary>
    public static partial class TypeInfoExtensions
    {

        /// <summary>
        /// Returns the short declaration for the current Type.
        /// </summary>
        /// <param name="type">The Type to act on.</param>
        /// <returns>The short declaration.</returns>
        public static string GetShortDeclaration(this Type type)
        {
            if (type == typeof(bool))
            {
                return "bool";
            }
            if (type == typeof(byte))
            {
                return "byte";
            }
            if (type == typeof(char))
            {
                return "char";
            }
            if (type == typeof(decimal))
            {
                return "decimal";
            }
            if (type == typeof(double))
            {
                return "double";
            }
            if (type == typeof(Enum))
            {
                return "enum";
            }
            if (type == typeof(float))
            {
                return "float";
            }
            if (type == typeof(int))
            {
                return "int";
            }
            if (type == typeof(long))
            {
                return "long";
            }
            if (type == typeof(object))
            {
                return "object";
            }
            if (type == typeof(sbyte))
            {
                return "sbyte";
            }
            if (type == typeof(short))
            {
                return "short";
            }
            if (type == typeof(string))
            {
                return "string";
            }
            if (type == typeof(uint))
            {
                return "uint";
            }
            if (type == typeof(ulong))
            {
                return "ulong";
            }
            if (type == typeof(ushort))
            {
                return "ushort";
            }

            return type.Name;
        }

        /// <summary>
        /// Gets the declaration of the current Type.
        /// </summary>
        /// <param name="type">The Type to act on.</param>
        /// <returns>The declaration.</returns>
        public static string GetDeclaration(this Type type)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments>] [:] [Inherited Class] [Inherited Interface]
            StringBuilder sb = new StringBuilder();

            // Visibility
            sb.Append(type.IsPublic ? "public " : "internal ");

            // Modifier
            if (!type.IsInterface && type.IsAbstract)
            {
                sb.Append(type.IsSealed ? "static " : "abstract ");
            }

            // Type
            sb.Append(type.IsInterface ? "interface " : "class ");

            // Name
            sb.Append(type.IsGenericType ? type.Name.Substring(0, type.Name.IndexOf('`')) : type.Name);

            List<string> constraintType = new List<string>();

            // GenericArguments
            if (type.IsGenericType)
            {
                Type[] arguments = type.GetGenericArguments();
                sb.Append("<");
                sb.Append(string.Join(", ", arguments.Select(a =>
                {
                    GenericParameterAttributes sConstraints = a.GenericParameterAttributes;

                    if ((sConstraints & GenericParameterAttributes.Contravariant) != GenericParameterAttributes.None)
                    {
                        sb.Append("in ");
                    }
                    if ((sConstraints & GenericParameterAttributes.Covariant) != GenericParameterAttributes.None)
                    {
                        sb.Append("out ");
                    }

                    List<string> parameterConstraint = new List<string>();

                    if ((sConstraints & GenericParameterAttributes.ReferenceTypeConstraint) != GenericParameterAttributes.None)
                    {
                        parameterConstraint.Add("class");
                    }

                    if ((sConstraints & GenericParameterAttributes.DefaultConstructorConstraint) != GenericParameterAttributes.None)
                    {
                        parameterConstraint.Add("new()");
                    }

                    if (parameterConstraint.Count > 0)
                    {
                        constraintType.Add(a.Name + " : " + string.Join(", ", parameterConstraint));
                    }

                    return a.GetShortDeclaration();
                })));
                sb.Append(">");

                foreach (var argument in arguments)
                {
                    GenericParameterAttributes sConstraints = argument.GenericParameterAttributes & GenericParameterAttributes.SpecialConstraintMask;
                }
            }

            List<string> constaints = new List<string>();

            // Inherited Class
            if (type.BaseType != null && type.BaseType != typeof(object)) // TODO: Maybe we want to include object
            {
                constaints.Add(type.BaseType.GetShortDeclaration());
            }

            // Inherited Interfaces
            Type[] interfaces = type.GetInterfaces();
            if (interfaces.Length > 0)
            {
                constaints.AddRange(interfaces.Select(i => i.IsGenericType ? i.Name.Substring(0, i.Name.IndexOf('`')) : i.Name));
            }

            if (constaints.Count > 0)
            {
                sb.Append(" : ");
                sb.Append(string.Join(", ", constaints));
            }

            if (constraintType.Count > 0)
            {
                sb.Append(" where ");
                sb.Append(string.Join(", ", constraintType));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Returns the short signature for the current Type.
        /// </summary>
        /// <param name="type">The Type to act on.</param>
        /// <returns>The short signature.</returns>
        public static string GetShortSignature(this Type type)
        {
            if (type == typeof(bool))
            {
                return "bool";
            }
            if (type == typeof(byte))
            {
                return "byte";
            }
            if (type == typeof(char))
            {
                return "char";
            }
            if (type == typeof(decimal))
            {
                return "decimal";
            }
            if (type == typeof(double))
            {
                return "double";
            }
            if (type == typeof(Enum))
            {
                return "enum";
            }
            if (type == typeof(float))
            {
                return "float";
            }
            if (type == typeof(int))
            {
                return "int";
            }
            if (type == typeof(long))
            {
                return "long";
            }
            if (type == typeof(object))
            {
                return "object";
            }
            if (type == typeof(sbyte))
            {
                return "sbyte";
            }
            if (type == typeof(short))
            {
                return "short";
            }
            if (type == typeof(string))
            {
                return "string";
            }
            if (type == typeof(uint))
            {
                return "uint";
            }
            if (type == typeof(ulong))
            {
                return "ulong";
            }
            if (type == typeof(ushort))
            {
                return "ushort";
            }

            return type.Name;
        }

        /// <summary>
        /// Gets the signature for the current Type.
        /// </summary>
        /// <param name="type">The Type to act on.</param>
        /// <returns>The signature.</returns>
        public static string GetSignature(this Type type)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments>] [:] [Inherited Class] [Inherited Interface]
            StringBuilder sb = new StringBuilder();

            // Name
            sb.Append(type.IsGenericType ? type.Name.Substring(0, type.Name.IndexOf('`')) : type.Name);

            // GenericArguments
            if (type.IsGenericType)
            {
                Type[] arguments = type.GetGenericArguments();
                sb.Append("<");
                sb.Append(string.Join(", ", arguments.Select(x =>
                {
                    Type[] constraints = x.GetGenericParameterConstraints();

                    foreach (Type constraint in constraints)
                    {
                        GenericParameterAttributes gpa = constraint.GenericParameterAttributes;
                        GenericParameterAttributes variance = gpa & GenericParameterAttributes.VarianceMask;

                        if (variance != GenericParameterAttributes.None)
                        {
                            sb.Append((variance & GenericParameterAttributes.Covariant) != 0 ? "in " : "out ");
                        }
                    }

                    return x.GetShortDeclaration();
                })));
                sb.Append(">");
            }

            return sb.ToString();
        }

    }
}
