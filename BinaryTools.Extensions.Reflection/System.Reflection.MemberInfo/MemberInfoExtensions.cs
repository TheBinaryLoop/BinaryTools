using System;
using System.Reflection;

namespace BinaryTools.Extensions.Reflection
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="MemberInfo"/> class.
    /// </summary>
    public static partial class MemberInfoExtensions
    {

#if NETSTANDARD2_0_OR_GREATER || NETFULL

        /// <summary>
        /// Retrieves a custom attribute applied to a member of a type. Parameters specify the member, and the type of the custom attribute 
        /// to search for.
        /// </summary>
        /// <param name="element">
        /// An object derived from the <see cref="MemberInfo"/> class that describes a constructor, event, field, method, or property member of a class.
        /// </param>
        /// <param name="attributeType">
        /// The type, or a base type, of the custom attribute to search for.
        /// </param>
        /// <returns>
        /// A reference to the single custom attribute of type attributeType that is applied to element, or null if there is no such 
        /// attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttribute(element, attributeType);
        }

        /// <summary>
        /// Retrieves a custom attribute applied to a member of a type. Parameters specify the member, the type of the custom attribute to 
        /// search for, and whether to search ancestors of the member.
        /// </summary>
        /// <param name="element">
        /// An object derived from the <see cref="MemberInfo"/> class that describes a constructor, event, field, method, or property member of a class.
        /// </param>
        /// <param name="attributeType">
        /// The type, or a base type, of the custom attribute to search for.
        /// </param>
        /// <param name="inherit">
        /// If true, specifies to also search the ancestors of element for custom attributes.
        /// </param>
        /// <returns>
        /// A reference to the single custom attribute of type attributeType that is applied to element, or null if there is no such 
        /// attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttribute(element, attributeType, inherit);
        }

        /// <summary>
        /// Gets the declaration of the current MemberInfo.
        /// </summary>
        /// <param name="memberInfo">The MemberInfo to act on.</param>
        /// <returns>The declaration.</returns>
        public static string GetDeclaration(this MemberInfo memberInfo)
        {
            switch (memberInfo.MemberType)
            {
                case MemberTypes.Field:
                    return ((FieldInfo)memberInfo).GetDeclaration();
                case MemberTypes.Property:
                    return ((PropertyInfo)memberInfo).GetDeclaration();
                case MemberTypes.Constructor:
                    return ((ConstructorInfo)memberInfo).GetDeclaration();
                case MemberTypes.Method:
                    return ((MethodInfo)memberInfo).GetDeclaration();
                case MemberTypes.TypeInfo:
                    return ((Type)memberInfo).GetDeclaration();
                case MemberTypes.NestedType:
                    return ((Type)memberInfo).GetDeclaration();
                case MemberTypes.Event:
                    return ((EventInfo)memberInfo).GetDeclaration();
                default:
                    return null;
            }
        }

        /// <summary>
        /// Gets the signature of the current MemberInfo.
        /// </summary>
        /// <param name="memberInfo">The MemberInfo to act on.</param>
        /// <returns>The signature.</returns>
        public static string GetSignature(this MemberInfo memberInfo)
        {
            switch (memberInfo.MemberType)
            {
                case MemberTypes.Field:
                    return ((FieldInfo)memberInfo).GetSignature();
                case MemberTypes.Property:
                    return ((PropertyInfo)memberInfo).GetSignature();
                case MemberTypes.Constructor:
                    return ((ConstructorInfo)memberInfo).GetSignature();
                case MemberTypes.Method:
                    return ((MethodInfo)memberInfo).GetSignature();
                case MemberTypes.TypeInfo:
                    return ((Type)memberInfo).GetSignature();
                case MemberTypes.NestedType:
                    return ((Type)memberInfo).GetSignature();
                case MemberTypes.Event:
                    return ((EventInfo)memberInfo).GetSignature();
                default:
                    return null;
            }

        }

        /// <summary>
        /// Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, and the type of 
        /// the custom attribute to search for.
        /// </summary>
        /// <param name="element">
        /// An object derived from the <see cref="MemberInfo"/> class that describes a constructor, event, field, method, type, or property member of a 
        /// class.
        /// </param>
        /// <param name="attributeType">
        /// The type, or a base type, of the custom attribute to search for.
        /// </param>
        /// <returns>true if a custom attribute of type attributeType is applied to element; otherwise, false.</returns>
        public static bool IsDefined(this MemberInfo element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        /// <summary>
        /// Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, the type of the 
        /// custom attribute to search for, and whether to search ancestors of the member.
        /// </summary>
        /// <param name="element">
        /// An object derived from the <see cref="MemberInfo"/> class that describes a constructor, event, field, method, type, or property member of a 
        /// class.
        /// </param>
        /// <param name="attributeType">
        /// The type, or a base type, of the custom attribute to search for.
        /// </param>
        /// <param name="inherit">
        /// If true, specifies to also search the ancestors of element for custom attributes.
        /// </param>
        /// <returns>true if a custom attribute of type attributeType is applied to element; otherwise, false.</returns>
        public static bool IsDefined(this MemberInfo element, Type attributeType, bool inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }

#endif

    }
}
