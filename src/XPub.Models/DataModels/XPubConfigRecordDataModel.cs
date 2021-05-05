using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XPub.Interfaces.Models;
using XPub.Interfaces.Models.DataModels;

namespace XPub.Models.DataModels
{
    /// <summary>
    /// XPubConfigRecordDataModel  data model concrete class derived from the class  <see cref="XPubModel"/>
    /// , and the interface <seealso cref="IXPubConfigRecordDataModel"/>
    /// Used for data binding to views
    /// </summary>

    public class XPubConfigRecordDataModel : XPubModel
        , IXPubConfigRecordDataModel
    {
        #region Property Accessors
        /// <summary>
        /// FileSize Property Get  Set Accessor
        /// Size of file
        /// </summary>
        ///<value>
        /// Nullable Long
        ///</value>
        public long? FileSize { get; set; }

        /// <summary>
        /// FileName Property Get  Set Accessor
        /// Nmae of a file
        /// </summary>
        ///<value>
        /// string
        ///</value>
        [DisplayName("File Type")]
        public string FileName { get; set; }

        /// <summary>
        /// FileType Property Get  Set Accessor
        /// Type of file
        /// </summary>
        ///<value>
        /// string
        ///</value>
        [DisplayName("File Type")]
        public string FileType { get; set; }


        /// <summary>
        /// DateReceived Property Get  Set Accessor
        /// Date of when file was received
        /// </summary>
        ///<value>
        /// nullable DateTimeOffset
        ///</value>
        [DisplayName("Date Received")]
        public DateTimeOffset? DateReceived { get; set; }

        /// <summary>
        /// RecordFile Property Get  Set Accessor
        /// Name of the record file type
        /// </summary>
        ///<value>
        /// string
        ///</value>
        [DisplayName("Record File")]
        public string RecordFile { get; set; }

        #endregion
    }
}
