using System;

using R5T.T0035.X002;


namespace System
{
    public static class IMicrosoftNamespaceNameExtensions
    {
        public static string Value(this IMicrosoftNamespaceName _)
        {
            return MicrosoftNamespaceNames.Microsoft;
        }


        public static IMicrosoftExtensionsNamespaceName Extensions(this IMicrosoftNamespaceName _)
        {
            return MicrosoftExtensionsNamespaceName.Instance;
        }
    }
}