using System;

using R5T.T0035.X001;


namespace System
{
    public static class ISystemNamespaceNameExtensions
    {
        public static string Value(this ISystemNamespaceName _)
        {
            return SystemNamespaceNames.System;
        }


        public static ISystemThreadingNamespaceName Threading(this ISystemNamespaceName _)
        {
            return SystemThreadingNamespaceName.Instance;
        }
    }
}