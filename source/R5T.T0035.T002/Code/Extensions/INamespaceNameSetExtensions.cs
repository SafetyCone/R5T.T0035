using System;

using R5T.L0011.T004;

using R5T.T0035.T002;


namespace System
{
    public static class INamespaceNameSetExtensions
    {
        public static IUsingDirectivesBlockList GetBlocks(this INamespaceNameSet set)
        {
            var labeler = new DefaultNamespaceNameLabeler();

            var output = set.GetBlocks(labeler);
            return output;
        }
    }
}
