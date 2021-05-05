namespace XPub.Infrastructure
{
    /// <summary>
    /// IAccordionRootItem interface
    /// Specifies accordion root item
    /// </summary>
    public interface IAccordionRootItem
    {
        #region Property Accessors

        /// <summary>
        /// DefaultNavigationPath Property Get Accessor
        /// Specifies default navigation path
        /// </summary>
        /// <value> string</value>
        string DefaultNavigationPath { get; }
        #endregion
    }
}
