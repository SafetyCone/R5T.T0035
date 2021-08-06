using System;
using System.Linq;

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

        public static string[] GetTokens(this INamespaceName namespaceName,
            string namespaceNameValue)
        {
            var output = StringHelper.Split(namespaceName.TokenSeparator(), namespaceNameValue);
            return output;
        }

        public static string GetLastToken(this INamespaceName namespaceName,
            string fullyQualifiedTypeNameValue)
        {
            var tokens = namespaceName.GetTokens(fullyQualifiedTypeNameValue);

            var output = tokens.Last();
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
