using System;


namespace R5T.T0035
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespaceNameValue : INamespaceNameValue
    {
        #region Static

        public static NamespaceNameValue Instance { get; } = new();

        #endregion
    }
}