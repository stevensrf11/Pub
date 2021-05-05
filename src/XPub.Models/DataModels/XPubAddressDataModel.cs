using System;
using System.Collections.Generic;
using System.Text;
using XPub.Resources.Enums;

namespace XPub.Models.DataModels
{
    /// <summary>
    /// XPubAddressDataModel object derived from the <see cref="XPubViewModelBase"/> object
    /// Contains base address information
    /// </summary>
    public class XPubAddressDataModel : XPubViewModelBase
    {
        #region Property Get / Set Accessors
        /// <summary>
        ///   City  Property Get/Set Accessor
        ///  City 
        /// </summary>
        /// <value>string</value>
        private string _city;
        public string City { 
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }


        /// <summary>
        ///   Line  Property Get/Set Accessor
        ///  Line physical location
        /// </summary>
        /// <value>string</value>
        private string _line;
        public string Line
        {
            get { return _line; }
            set { SetProperty(ref _line, value); }
        }

        /// <summary>
        ///   State  Property Get/Set Accessor
        ///  Two letter code for abbreviation of state 
        /// </summary>
        /// <value>XPubStateEnum enumeration value</value>
        private XPubStateEnum _stateenum;
        public XPubStateEnum StateEnum { 
            get { return _stateenum; } 
            set {  SetProperty(ref _stateenum, value); } 
        }
        #endregion

        /// <summary>
        ///   ZipCode  Property Get/Set Accessor
        ///  ZipCodeof state 
        /// </summary>
        /// <value>string</value>
        private string _zipCode;
        public string ZipCode { 
            get { return _zipCode; } 
            set { SetProperty(ref _zipCode, value); } 
        }

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public XPubAddressDataModel()
        {
            Initialize();
        }
        #endregion
        void Initialize()
        {
            //Line = "6755 Newlin Ave";
            //City = "Whittier";
            //State = StateEnum.AK;
            //ZipCode = "90601";
        }
    }
}
