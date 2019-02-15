using System;
using System.Linq;
using System.Reflection;

namespace BinaryTools.Extensions.Core
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Object"/> class.
    /// </summary>
    public static partial class ObjectExtensions
    {

#if !NETSTANDARD1_3

        /// <summary>
        /// Invokes a method regardless of its protection or visibility level.
        /// </summary>
        /// <param name="o">The object to act on.</param>
        /// <param name="methodName">The name of method to invoke.</param>
        /// <param name="args">Arguments to be passed to the invoked method.</param>
        /// <returns>The return value of the invoked method or null.</returns>
        public static object InvokeMethod(this object o, string methodName, params Object[] args)
        {
            Type[] methodParamTypes = args?.Select(p => p.GetType()).ToArray() ?? new Type[] { };
            BindingFlags bindingFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static;
            MethodInfo methodInfo = o.GetType().GetMethod(methodName, bindingFlags, Type.DefaultBinder, methodParamTypes, null);
            try
            {
                if (methodName != null)
                {
                    return methodInfo.Invoke(o, args);
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            return null;
        }


        /// <summary>
        /// Invokes a method regardless of its protection or visibility level.
        /// </summary>
        /// <typeparam name="T">The return type of the invoked method.</typeparam>
        /// <param name="o">The object to act on.</param>
        /// <param name="methodName">The name of method to invoke.</param>
        /// <param name="args">Arguments to be passed to the invoked method.</param>
        /// <returns>The return value of the invoked method or the default of T.</returns>
        public static T InvokeMethod<T>(this object o, string methodName, params Object[] args)
        {
            Type[] methodParamTypes = args?.Select(p => p.GetType()).ToArray() ?? new Type[] { };
            BindingFlags bindingFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static;
            MethodInfo methodInfo = o.GetType().GetMethod(methodName, bindingFlags, Type.DefaultBinder, methodParamTypes, null);
            try
            {
                if (methodName != null)
                {
                    return (T)methodInfo.Invoke(o, args);
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            return default(T);
        }

#endif

    }
}
