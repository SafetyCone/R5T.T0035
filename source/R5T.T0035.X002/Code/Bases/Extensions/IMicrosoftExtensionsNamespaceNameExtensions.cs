using System;

using R5T.T0035.X002;


namespace System
{
    public static class IMicrosoftExtensionsNamespaceNameExtensions
    {
        public static string Value(this IMicrosoftExtensionsNamespaceName _)
        {
            return MicrosoftNamespaceNames.Microsoft_Extensions;
        }


        public static IMicrosoftExtensionsDependencyInjectionNamespaceName DependencyInjection(this IMicrosoftExtensionsNamespaceName _)
        {
            return MicrosoftExtensionsDependencyInjectionNamespaceName.Instance;
        }
    }
}