using System;
using System.Collections.Generic;
using System.Text;

namespace XPub.Interfaces.Models.DataModels
{
    /// <summary>
    /// IXPubConfigRecordDataModel  interface model derived  from the interface <see cref="IXPubRecordModel"/>
    /// Data model for interface for configuration record views
    /// </summary>
    public interface IXPubConfigRecordDataModel :IXPubRecordModel
    {
        #region Property Accessors


        /// <summary>
        /// RecordFile Property Get  Set Accessor
        /// Name of the record file type
        /// </summary>
        ///<value>
        /// string
        ///</value>
        string RecordFile { get; set; }


        #endregion

    }
}
