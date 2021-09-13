using System;

using R5T.T0035;
using R5T.T0035.X001;


namespace System
{
    public static class INamespaceNameExtensions
    {
        public static bool IsInSystem(this INamespaceName namespaceName, string namespaceNameValue)
        {
            var output = namespaceName.IsIn(namespaceNameValue, namespaceName.System().Value());
            return output;
        }

        public static ISystemNamespaceName System(this INamespaceName _)
        {
            return SystemNamespaceName.Instance;
        }
    }
}