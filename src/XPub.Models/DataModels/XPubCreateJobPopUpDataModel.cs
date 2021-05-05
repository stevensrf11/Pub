using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace XPub.Models.DataModels
{
    /// <summary>
    /// XPubCreateJobPopUpModel object
    /// Data model for the create job edit pop up
    /// </summary>
    public class XPubCreateJobPopUpDataModel
    {
        #region Property Accessors
        #region Meta Data One group.T wo items  which go to the horizontally oriented Meta Data One group.
        [Display(GroupName = "Meta Data One-", Name = "Mata Data Now")]
        public string MetaDataOneNow { get; set; }
        [Display(GroupName = "Meta Data One-", Name = "Mata Data Then", Order = 1)]
        public string MetaDataOneThen { get; set; }
        #endregion
       
        #region Meta Data Two group.T wo items  which go to the horizontally oriented Meta Data Two group.
        [Display(GroupName = "Meta Data Two-", Name = "Mata Data Now")]
        public string MetaDataTwoNow { get; set; }
        [Display(GroupName = "Meta Data Two-", Name = "Mata Data Then", Order = 3)]
        public string MetaDataTwoThen { get; set; }
        #endregion
        #endregion
    }
}
