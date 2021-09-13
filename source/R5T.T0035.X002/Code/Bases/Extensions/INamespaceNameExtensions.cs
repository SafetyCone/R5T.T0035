using System;

using R5T.T0035;
using R5T.T0035.X002;


namespace System
{
    public static class INamespaceNameExtensions
    {
        public static bool IsInMicrosoft(this INamespaceName namespaceName, string namspaceNameValue)
        {
            var output = namespaceName.IsIn(namspaceNameValue, namespaceName.Microsoft().Value());
            return output;
        }

        public static IMicrosoftNamespaceName Microsoft(this INamespaceName _)
        {
            return MicrosoftNamespaceName.Instance;
        }
    }
}