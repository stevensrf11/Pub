namespace XPub.Interfaces.Models
{
    /// <summary>
    /// IXPubViewModel base view model interface derived from <see cref="IXPub"/> interface
    /// </summary>
    public interface IXPubViewModel : IXPub
    {
        #region Property Accessors
        /// <summary>
        /// Title Property Get  Set Accessor
        /// </summary>
        /// <value>
        /// string
        /// </value>
        string Title { get; set; }
        #endregion
    }
}
