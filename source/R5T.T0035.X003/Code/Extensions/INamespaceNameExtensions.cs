using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0035;


namespace System
{
    public static class INamespaceNameExtensions
    {
        public static string AppendToken(this INamespaceName _,
            string baseNamespaceName,
            string namespaceNameToken)
        {
            var output = $"{baseNamespaceName}{_.TokenSeparator()}{namespaceNameToken}";
            return output;
        }

        public static string CombineTokens(this INamespaceName _,
            IEnumerable<string> namespaceNameTokens)
        {
            var output = String.Join(_.TokenSeparatorCharacter(), namespaceNameTokens);
            return output;
        }

        public static string[] GetTokens(this INamespaceName _,
            string namespaceName)
        {
            var output = StringHelper.Split(_.TokenSeparator(), namespaceName);
            return output;
        }

        public static string GetLastToken(this INamespaceName _,
            string fullyQualifiedTypeNameValue)
        {
            var tokens = _.GetTokens(fullyQualifiedTypeNameValue);

            var output = tokens.Last();
            return output;
        }

        public static bool Is(this INamespaceName _,
            string namespaceName,
            string targetNamespaceName)
        {
            var output = namespaceName == targetNamespaceName;
            return output;
        }

        public static bool IsIn(this INamespaceName _,
            string namespaceName,
            string baseNamespaceName)
        {
            if (namespaceName.Length < baseNamespaceName.Length)
            {
                return false;
            }

            var output = namespaceName.Substring(0, baseNamespaceName.Length) == baseNamespaceName;
            return output;
        }

        public static bool IsOutside(this INamespaceName _,
            string namespaceName,
            string baseNamespaceName)
        {
            var isIn = _.IsIn(namespaceName, baseNamespaceName);

            var output = !isIn;
            return output;
        }

        public static string[] Tokenize(this INamespaceName _,
            string namespacedName)
        {
            var output = namespacedName.Split(_.TokenSeparatorCharacter(), StringSplitOptions.RemoveEmptyEntries); // There should be no empty entries, so remove them just in case. This should cause problems that will then have to be addressed: why do you have empty tokens in your namespace name?
            return output;
        }

        public static string TokenSeparator(this INamespaceName _)
        {
            return Strings.Period;
        }

        public static char TokenSeparatorCharacter(this INamespaceName _)
        {
            return Characters.Period;
        }
    }
}
