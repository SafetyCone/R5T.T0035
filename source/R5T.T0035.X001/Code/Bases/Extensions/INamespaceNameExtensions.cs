using System;

using R5T.T0035;
using R5T.T0035.X001;


namespace System
{
    public static class INamespaceNameExtensions
    {
        public static bool IsDefault(this INamespaceName _,
            string namespaceName)
        {
            var defaultNamespaceName = _.Values()._Default();

            var output = namespaceName == defaultNamespaceName;
            return output;
        }

        ///// <summary>
        ///// Returns true if <paramref name="namespaceName"/> is not the default.
        ///// </summary>
        //public static bool IsOverridden(this INamespaceName _,
        //    string namespaceName)
        //{
        //    var isDefault = _.IsDefault(namespaceName);

        //    var output = !isDefault;
        //    return output;
        //}

        public static bool IsInSystem(this INamespaceName _,
            string namespaceName)
        {
            var output = _.IsIn(namespaceName, _.System().Value());
            return output;
        }

        public static ISystemNamespaceName System(this INamespaceName _)
        {
            return SystemNamespaceName.Instance;
        }
    }
}