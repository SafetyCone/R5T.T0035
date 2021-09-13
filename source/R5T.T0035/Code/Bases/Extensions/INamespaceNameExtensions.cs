using System;

using R5T.T0035;


namespace System
{
    public static class INamespaceNameExtensions
    {
        public static INamespaceNameValue Values(this INamespaceName _)
        {
            return NamespaceNameValue.Instance;
        }
    }
}
