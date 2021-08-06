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

        public static bool Is(this INamespaceName _, string namespaceName, string targetNamespaceName)
        {
            var output = namespaceName == targetNamespaceName;
            return output;
        }

        public static bool IsIn(this INamespaceName _, string namespaceName, string baseNamespaceName)
        {
            if (namespaceName.Length < baseNamespaceName.Length)
            {
                return false;
            }

            var output = namespaceName.Substring(0, baseNamespaceName.Length) == baseNamespaceName;
            return output;
        }

        public static string TokenSeparator(this INamespaceName _)
        {
            return Strings.Period;
        }
    }
}
