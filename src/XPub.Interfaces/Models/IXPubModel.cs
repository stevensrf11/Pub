using System;
using System.Collections.Generic;
using System.Text;

namespace XPub.Interfaces.Models
{
    /// <summary>
    /// IXPubModel  interface model derived  from the interface <see cref="IXPub"/>
    /// </summary>
    public interface IXPubModel : IXPub
    {
        #region Property Accessors
        /// <summary>
        /// Id Property Get  Set Accessor
        /// XPub Model  Identification number
        /// </summary>
        ///<value>
        /// Nullable Long
        ///</value>
        long? Id { get; set; }

        /// <summary>
        /// IDGuid Property Get  Set Accessor
        /// XPub Model Guid Identification 
        /// </summary>
        ///<value>
        /// Nullable Guid
        ///</value>
        Guid? IDGuid { get; set; }

        /// <summary>
        /// IDString Property Get  Set Accessor
        /// XPub Model  string Identification 
        /// </summary>
        ///<value>
        /// Nullable Guid
        ///</value>
        string IDString { get; set; }
        #endregion


    }
}
