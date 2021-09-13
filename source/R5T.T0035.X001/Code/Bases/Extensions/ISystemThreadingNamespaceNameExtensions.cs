using System;

using R5T.T0035.X001;


namespace System
{
    public static class ISystemThreadingNamespaceNameExtensions
    {
        public static string Value(this ISystemThreadingNamespaceName _)
        {
            return SystemNamespaceNames.System_Threading;
        }


        public static ISystemThreadingTasksNamespaceName Tasks(this ISystemThreadingNamespaceName _)
        {
            return SystemThreadingTasksNamespaceName.Instance;
        }
    }
}