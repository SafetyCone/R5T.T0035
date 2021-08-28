using System;


namespace R5T.T0035.X001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SystemNamespaceName : ISystemNamespaceName
    {
        #region Static

        public static SystemNamespaceName Instance { get; } = new();

        #endregion
    }
}