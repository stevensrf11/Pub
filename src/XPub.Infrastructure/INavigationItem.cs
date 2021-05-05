namespace XPub.Infrastructure
{
    /// <summary>
    /// INavigationItem interface
    /// Specifies navigation use
    /// </summary>
    public interface INavigationItem
    {
        #region Property Accessors
        /// <summary>
        /// NavigationPath Property Get Set Accessor
        /// Specifies navigation path 
        /// </summary>
        /// <value>string</value>
        string NavigationPath { get; set; }
        #endregion
    }
}
