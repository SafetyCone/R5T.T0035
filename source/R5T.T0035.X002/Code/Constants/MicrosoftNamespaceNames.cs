using System;


namespace R5T.T0035.X002
{
    public static class MicrosoftNamespaceNames
    {
        public static string Microsoft => "Microsoft";
        public static string Microsoft_Extensions => Instances.NamespaceName.AppendToken(Microsoft, "Extensions");
        public static string Microsoft_Extensions_Configuration => Instances.NamespaceName.AppendToken(Microsoft_Extensions, "Configuration");
        public static string Microsoft_Extensions_DependencyInjection => Instances.NamespaceName.AppendToken(Microsoft_Extensions, "DependencyInjection");
        public static string Microsoft_Extensions_Hosting => Instances.NamespaceName.AppendToken(Microsoft_Extensions, "Hosting");
        public static string Microsoft_Extensions_Logging => Instances.NamespaceName.AppendToken(Microsoft_Extensions, "Logging");
    }
}
