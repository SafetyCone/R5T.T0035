using System;

using R5T.T0035;
using R5T.T0035.X002;


namespace System
{
    public static class INamespaceNameExtensions
    {
        public static IMicrosoftNamespaceName System(this INamespaceName _)
        {
            return MicrosoftNamespaceName.Instance;
        }
    }
}