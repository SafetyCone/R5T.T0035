using System;


namespace R5T.T0035.X002
{
    public static class MicrosoftNamespaceNames
    {
        public static string Microsoft => "Microsoft";
        public static string Microsoft_Extensions => Instances.NamespaceName.AppendToken(Microsoft, "Extensions");
        public static string Microsoft_Extensions_DependencyInjection => Instances.NamespaceName.AppendToken(Microsoft_Extensions, "DependencyInjection");
    }
}
