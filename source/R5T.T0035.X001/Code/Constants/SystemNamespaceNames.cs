using System;


namespace R5T.T0035.X001
{
    public static class SystemNamespaceNames
    {
        public static string System => "System";
        public static string System_Threading => Instances.NamespaceName.AppendToken(System, "Threading");
        public static string System_Threading_Tasks => Instances.NamespaceName.AppendToken(System_Threading, "Tasks");
    }
}
