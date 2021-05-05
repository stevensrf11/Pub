using System;
using System.Collections.Generic;
using System.Text;

namespace XPub.Models.DataModels
{
    /// <summary>
    /// XPubJobManagementTaskPoolDataModel object
    ///  Contains a job's task information
    /// </summary>
    public class XPubJobManagementTaskPoolDataModel
    {
        #region Property Accessors
        public string Task { get; set; }

        public string FileName { get; set; }

        public string AssingedTo { get; set; }

        public string Status { get; set; }

        public string TimeInQueue { get; set; }

        #endregion
    }
}
