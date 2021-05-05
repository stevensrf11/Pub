using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XPub.Interfaces.Models
{
    /// <summary>
    /// IXPubRecordModel  interface model derived  from the interface <see cref="IXPubModel"/>
    /// </summary>
   public  interface IXPubRecordModel : IXPubModel
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
