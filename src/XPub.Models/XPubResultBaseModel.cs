using System;
using System.Collections.Generic;
using System.Text;
using XPub.Interfaces.Models;
using XPub.Resources.Enums;

namespace XPub.Models
{
    /// <summary>
    /// IXPubResultBaseModel  model concrete class derived from the class  <see cref="XPubModel"/>
    /// , and the interface <seealso cref="IXPubResultBaseModel"/>
    /// Contains the results of an operation
    /// </summary>
    public class XPubResultBaseModel : XPubModel
        , IXPubResultBaseModel
    {
        #region Accessors
        /// <summary>
        /// ResultSuccess Get/Set Accessor
        /// True if operation was successful
        /// </summary>
        /// <value> boolean</value>
        public bool ResultSuccess { get; set; }

        /// <summary>
        /// HasErrors Get/Set Accessor
        /// True if operation has errors
        /// </summary>
        /// <value> boolean</value>
        public bool HasErrors { get; set; }

        /// <summary>
        /// Errors  Get/Set Accessor
        /// Contains collection of  of errors
        /// </summary>
        /// <value> Collection of strings</value>
        public IList<string> Errors { get; set; }

        /// <summary>
        /// ResultOperation  Get/Set Accessor
        /// Contains result base type of operation
        /// </summary>
        /// <value> enumeration value</value>
        public XPubResultBaseOperationEnums ResultOperation { get; set; }

        /// <summary>
        /// ResultContent Get/Set Accessor
        /// Contains content result of operation
        /// </summary>
        /// <value> dynamic</value>
        public dynamic ResultContent { get; set; }
        #endregion
    }
}
