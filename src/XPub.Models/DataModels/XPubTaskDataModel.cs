using System;
using XPub.Resources.Enums;

namespace XPub.Models.DataModels
{
    /// <summary>
    /// XPubTaskDataModel object
    /// Represents task object
    /// </summary>
    public class XPubTaskDataModel
    {
        #region Property Get/Set Accessors
        /// <summary>
        ///   Completion Property Get/Set Accessor
        ///   Percent completed
        /// </summary>
        /// <value>nullable int</value>
        public int? Completion { get; set; }

        /// <summary>
        ///  Description Property Get/Set Accessor
        ///   Describes what task it
        /// </summary>
        /// <value>string</value>
        public string Description { get; set; }

        /// <summary>
        ///  DueDate Property Get/Set Accessor
        ///   Date task is due by
        /// </summary>
        /// <value>nullable DateTimeOffset</value>
        public DateTimeOffset? DueDate { get; set; }

        /// <summary>
        ///  Priority Property Get/Set Accessor
        ///   Priority importance
        /// </summary>
        /// <value>XPubTaskPriorityEnum enumeration value</value>
        public XPubTaskPriorityEnum Priority { get; set; }

        /// <summary>
        /// StartDate  Property Get/Set Accessor
        ///  Date task began 
        /// </summary>
        /// <value>nullable DateTimeOffset</value>
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        ///   Property Get/Set Accesor
        ///   
        /// </summary>
        /// <value></value>
        public string Subject { get; set; }
        #endregion
    }
}
