using System;


namespace R5T.T0035
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespaceName : INamespaceName
    {
        #region Static

        public static NamespaceName Instance { get; } = new();

        #endregion
    }
}