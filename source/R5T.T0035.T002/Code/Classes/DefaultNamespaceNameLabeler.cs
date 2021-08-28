using System;

using R5T.Magyar;

using R5T.L0011.X002;


namespace R5T.T0035.T002
{
    public class DefaultNamespaceNameLabeler : ILabeler<string>
    {
        public string Label(string namespaceName)
        {
            this.CanLabel(namespaceName, out var label);

            return label;
        }

        protected virtual bool CanLabel(string namespaceName, out string label)
        {
            if (Instances.NamespaceName.IsInSystem(namespaceName))
            {
                label = Instances.UsingDirectivesBlockLabel.System();
                return true;
            }

            if (Instances.NamespaceName.IsInMicrosoft(namespaceName))
            {
                label = Instances.UsingDirectivesBlockLabel.Microsoft();
                return true;
            }

            label = Instances.UsingDirectivesBlockLabel.Uncategorized();
            return false;
        }
    }
}
