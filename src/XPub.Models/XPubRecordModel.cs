using System;
using System.Collections.Generic;
using System.Text;
using XPub.Interfaces.Models;

namespace XPub.Models
{
    /// <summary>
    /// XPubRecordModel  model concrete class derived from the class  <see cref="XPubModel"/>
    /// , and the interface <seealso cref="IXPubRecordModel"/>
    /// </summary>

    public class XPubRecordModel :XPubModel
        , IXPubRecordModel
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
        public string FileName { get; set; }

        /// <summary>
        /// FileType Property Get  Set Accessor
        /// Type of file
        /// </summary>
        ///<value>
        /// string
        ///</value>
        public string FileType { get; set; }


        /// <summary>
        /// DateReceived Property Get  Set Accessor
        /// Date of when file was received
        /// </summary>
        ///<value>
        /// nullable DateTimeOffset
        ///</value>
        public DateTimeOffset? DateReceived { get; set; }

        #endregion
    }
}
