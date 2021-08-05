using System;

using R5T.T0035;


namespace System
{
    public static class INamespaceNameExtensions
    {
        public static string AppendToken(this INamespaceName namespaceName,
            string baseNamespaceName,
            string namespaceNameToken)
        {
            var output = $"{baseNamespaceName}{namespaceName.TokenSeparator()}{namespaceNameToken}";
            return output;
        }

        public static string TokenSeparator(this INamespaceName _)
        {
            return Strings.Period;
        }
    }
}
