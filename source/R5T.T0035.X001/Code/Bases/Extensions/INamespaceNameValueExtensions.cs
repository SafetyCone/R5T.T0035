using System;

using R5T.T0035;
using R5T.T0035.X001;


namespace System
{
    public static class INamespaceNameValueExtensions
    {
        public static string System(this INamespaceNameValue _)
        {
            return SystemNamespaceNames.System;
        }

        public static string System_Threading(this INamespaceNameValue _)
        {
            return SystemNamespaceNames.System_Threading;
        }

        public static string System_Threading_Tasks(this INamespaceNameValue _)
        {
            return SystemNamespaceNames.System_Threading_Tasks;
        }
    }
}
