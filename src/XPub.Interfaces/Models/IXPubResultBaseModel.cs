using System;
using System.Collections.Generic;
using System.Text;
using XPub.Resources.Enums;

namespace XPub.Interfaces.Models
{
    /// <summary>
    /// IXPubResultBaseModel  interface model derived  from the interface <see cref="IXPubModel"/>
    /// Contains results of an operation
    /// </summary>
    public interface IXPubResultBaseModel : IXPubModel
    {
        #region Accessors
        /// <summary>
        /// ResultSuccess Get/Set Accessor
        /// True if operation was successful
        /// </summary>
        /// <value> boolean</value>
        bool ResultSuccess { get; set; }

        /// <summary>
        /// HasErrors Get/Set Accessor
        /// True if operation has errors
        /// </summary>
        /// <value> boolean</value>
        bool HasErrors { get; set; }

        /// <summary>
        /// Errors  Get/Set Accessor
        /// Contains collection of  of errors
        /// </summary>
        /// <value> Collection of strings</value>
        IList<string> Errors { get; set; }

        /// <summary>
        /// ResultOperation  Get/Set Accessor
        /// Contains result base type of operation
        /// </summary>
        /// <value> enumeration value</value>
        XPubResultBaseOperationEnums ResultOperation { get; set; }

        /// <summary>
        /// ResultContent Get/Set Accessor
        /// Contains content result of operation
        /// </summary>
        /// <value> dynamic</value>
        dynamic ResultContent { get; set; }
        #endregion
    }
}
