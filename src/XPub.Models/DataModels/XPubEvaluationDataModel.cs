using System;
using System.Collections.Generic;
using System.Text;

namespace XPub.Models.DataModels
{
    /// <summary>
    /// XPubEvaluationDataModel object
    /// Provides evaluation information
    /// </summary>
    public class XPubEvaluationDataModel
    {
        #region Public Get / Set Accessors

        /// <summary>
        ///   CreatedOn Property Get/Set Accesor
        ///   Date the evalation was done on
        /// </summary>
        /// <value>nullable DateTimeOffset</value>
        public DateTimeOffset? CreatedOn { get; set; }

        /// <summary>
        ///   Manager Property Get/Set Accesor
        ///   Manager who done the evaluation
        /// </summary>
        /// <value>string</value>
        public string Manager { get; set; }

        /// <summary>
        ///   Subject Property Get/Set Accesor
        ///   Subject of the  evaluation
        /// </summary>
        /// <value>string</value>
        public string Subject
        {
            get; set;
           
        }
        #endregion
    }
}
