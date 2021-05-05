using System;
using System.Collections.Generic;
using System.Text;
using XPub.Interfaces.Models;

namespace XPub.Models
{

    /// <summary>
    /// XPubModel  model concrete class derived from the interface <see cref="IXPubModel"/>
    /// </summary>
    public class XPubModel : IXPubModel
    {
        #region Property Accessors
        /// <summary>
        /// Id Property Get  Set Accessor
        /// XPub Model  Identification number
        /// </summary>
        ///<value>
        /// Nullable Long
        ///</value>
        public long? Id { get; set; }

        /// <summary>
        /// IDGuid Property Get  Set Accessor
        /// XPub Model Guid Identification 
        /// </summary>
        ///<value>
        /// Nullable Guid
        ///</value>
        public Guid? IDGuid { get; set; }

        /// <summary>
        /// IDString Property Get  Set Accessor
        /// XPub Model  string Identification 
        /// </summary>
        ///<value>
        /// Nullable Guid
        ///</value>
        public string IDString { get; set; }
        #endregion
    }
}
