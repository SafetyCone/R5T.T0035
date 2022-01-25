using System;
using System.Linq;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.L0011.T004;


namespace System
{
    public static class CompilationUnitSyntaxExtensions
    {
        /// <summary>
        /// Handles both using namespace name directives and name aliases.
        /// </summary>
        public static CompilationUnitSyntax SetUsings(this CompilationUnitSyntax compilationUnit,
            UsingDirectivesSpecification usingDirectivesSpecification)
        {
            var namespaceNames = usingDirectivesSpecification.GetNamespaceNameSet();

            var usingDirectiveBlocks = namespaceNames.GetBlocks();

            var nameAliases = usingDirectivesSpecification.NameAliases
                .Select(x => x.GetUsingDirectiveSyntax().AppendBlankLine())
                .Now();

            var output = compilationUnit
                .SetUsings(usingDirectiveBlocks)
                .AddNameAliases(nameAliases);

            return output;
        }
    }
}
