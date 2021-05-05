using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using XPub.Resources.Enums;

namespace XPub.Infrastructure.Models
{
    ///  <summary>
    /// XPubNameModel object derived from the <see cref="BindableBase"/> object
    /// and the <seealso cref="ICloneable"/>interface
    /// Contains information for a grid column
    /// </summary>
    public class XPubNameModel : BindableBase, ICloneable
    {
        #region Property Get  / Set Accessors
        ///  <summary>
        /// FirstName Property Get  / Set Accessor
        /// Specifies  first name 
        /// </summary>
        /// <value>string</value>
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                    UpdateFullName();
                }
            }
        }

        ///  <summary>
        /// MiddleName Property Get  / Set Accessor
        /// Specifies  middle name 
        /// </summary>
        /// <value>string</value>
        string middleName;
        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (middleName != value)
                {
                    middleName = value;
                    RaisePropertyChanged("MiddleName");
                    UpdateFullName();
                }
            }
        }

        ///  <summary>
        /// LastName Property Get  / Set Accessor
        /// Specifies  last name 
        /// </summary>
        /// <value>string</value>
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");
                    UpdateFullName();
                }
            }
        }

        ///  <summary>
        /// FullName Property Get  / Set Accessor
        /// Specifies  full name 
        /// </summary>
        /// <value>string</value>
        string fullName;
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    RaisePropertyChanged("FullName");
                }
            }
        }
        ///  <summary>
        /// Title Property Get  / Set Accessor
        /// Specifies  the prefix salutation (Dr, Mr, Mrs...)
        /// </summary>
        /// <value>XPubPersonPrefixEnum enumeration value</value>
        XPubPersonPrefixEnum title;
        public XPubPersonPrefixEnum Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    RaisePropertyChanged("Title");
                    UpdateFullName();
                }
            }
        }
        #endregion
        #region Utility Methods

        ///  <summary>
        /// UpdateFullName  method 
        /// Updates the full name property based on existing name properties
        /// </summary>
        void UpdateFullName()
        {

            FullName = string.Format("{0}{1}{2}{3}", Title == XPubPersonPrefixEnum.None ? String.Empty : GetFormatString(Title.ToString()), GetFormatString(FirstName), GetFormatString(MiddleName), GetFormatString(LastName));
        }

        /// <summary>
        /// GetFormatString method
        /// </summary>
        /// <param name="name">Name to string format</param>
        /// <returns>Formated name or empty string</returns>
        string GetFormatString(string name)
        {
            if (string.IsNullOrEmpty(name))
                return string.Empty;
            return string.Format("{0} ", name);
        }

        #region Object Implementation
        ///  <summary>
        /// Assign  method 
        /// Updates XPubNameModel base properties
        /// </summary>
        /// <param name="name> XPubNameModel</param>
        public void Assign(XPubNameModel name)
        {
            this.FirstName = name.FirstName;
            this.MiddleName = name.MiddleName;
            this.LastName = name.LastName;
            this.Title = name.Title;
        }
        #endregion



        /// <summary>
        /// ToString over ride method 
        /// </summary>
        /// <returns>Full name string</returns>
        public override string ToString()
        {
            return FullName;
        }
        #endregion


        #region ICloneable Implementation
        ///  <summary>
        /// Clone method
        /// Create a new XPubNameModel from the existing one
        /// </summary>
        /// <returns>new initialized XPubNameModel</value>
        public object Clone()
        {
            return new XPubNameModel { FirstName = this.FirstName, MiddleName = this.MiddleName, LastName = this.LastName, FullName = this.FullName, Title = this.Title };
        }
        #endregion
    }

}
