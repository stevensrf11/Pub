using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using XPub.Resources.Enums;

namespace XPub.Infrastructure.Models
{
    /// <summary>
    /// XPubContactModel object derived from the <see cref="BindableBase"/> object,
    /// and the <seealso cref="ICloneable"/> interface
    /// Contains the contact information
    /// </summary>
    public class XPubContactModel : BindableBase, ICloneable
    {
        #region Fields

        #endregion


        #region Property Accessors
        /// <summary>
        /// XPubNameModel Property Get/ Set Accessor
        /// Contains name model 
        /// </summary>
        /// <value> XPubNameModel object</value>
        XPubNameModel _name;
      public XPubNameModel Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }


        /// <summary>
        /// ImageSource Property Get/ Set Accessor
        /// Contains image object for displaying image
        /// </summary>
        /// <value> ImageSource object</value>
        ImageSource _photo;  
        public ImageSource Photo
        {
            get { return _photo; }
            set
            {
                if (_photo != value)
                {
                    _photo = value;
                    RaisePropertyChanged("Photo");
                }
            }
        }


        /// <summary>
        /// FirstName Property Get Accessor
        /// Contains First tName
        /// </summary>
        /// <value> string</value>
        public string FirstName 
        { 
            get { return this.Name != null ? this.Name.FirstName : null; } 
        }

        /// <summary>
        /// LastName Property Get Accessor
        /// Contains Last tName
        /// </summary>       
        public string LastName 
        { 
            get { return this.Name != null ? this.Name.LastName : null; } 
        }

        /// <summary>
        /// XPubAddressModel Property Get/ Set Accessor
        /// Contains address model 
        /// </summary>
        /// <value> XPubAddressModel object</value>
        XPubAddressModel address;
        public XPubAddressModel Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    RaisePropertyChanged("Address");
                }
            }
        }

        /// <summary>
        /// Email Property Get/ Set Accessor
        /// Contains email
        /// </summary>
        /// <value> String</value>
        string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    RaisePropertyChanged("Email");
                }
            }
        }

        /// <summary>
        /// Phone Property Get/ Set Accessor
        /// Contains phone
        /// </summary>
        /// <value> String</value>
        string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                if (phone != value)
                {
                    phone = value;
                    RaisePropertyChanged("Phone");
                }
            }
        }

        /// <summary>
        /// BirthDate Property Get/ Set Accessor
        /// Contains birthDate
        /// </summary>
        /// <value> DateTime</value>       
        DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (birthDate != value)
                {
                    birthDate = value;
                    RaisePropertyChanged("BirthDate");
                }
            }
        }

        /// <summary>
        /// XPubPersonPrefixEnum Property Get/ Set Accessor
        /// Contains prefix salutation (Dr,Mr,Mrs, etc)
        /// </summary>
        /// <value> XPubPersonPrefixEnum enumeration</value>  
        XPubPersonPrefixEnum _prefix;
        public XPubPersonPrefixEnum Prefix
        {
            get { return _prefix; }
            set
            {
                if (!object.Equals(_prefix, value))
                {
                    _prefix = value;
                    RaisePropertyChanged("Prefix");
                }
            }
        }

        /// <summary>
        /// Notes Property Get/ Set Accessor
        /// Contains notes
        /// </summary>
        /// <value> string</value>     
        string notes;
        public string Notes
        {
            get { return notes; }
            set
            {
                if (notes != value)
                {
                    notes = value;
                    RaisePropertyChanged("Notes");
                }
            }
        }

        /// <summary>
        /// Activity Property Get/ Set Accessor
        /// Contains activity list indexes
        /// </summary>
        /// <value> list of integers</value> 
        List<int> activity;
        public List<int> Activity
        {
            get { return activity; }
            set
            {
                if (activity != value)
                {
                    activity = value;
                    RaisePropertiesChanged("Activity");
                }
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// XPubContactModel default constructor
        /// Creates new XPubNameModel and XPubAddressModel objects
        /// </summary>
        public XPubContactModel()
        {
            Name = new XPubNameModel();
            Address = new XPubAddressModel();
        }
        #endregion

        #region Utility Methods
        /// <summary>
        /// Assign method
        /// Updates XPubContactModel base properties
        /// </summary>
        /// <param name="contact"></param>
        public void Assign(XPubContactModel contact)
        {
            this.Name.Assign(contact.Name);
            this.Photo = contact.Photo;
            this.Address.Assign(contact.Address);
            this.Email = contact.Email;
            this.Phone = contact.Phone;
            this.BirthDate = contact.BirthDate;
            this.Prefix = contact.Prefix;
            this.Notes = contact.Notes;
            this.Activity = contact.Activity;
            RaisePropertiesChanged(string.Empty);
        }
        #endregion

        #region ICloneable Implementation 
        /// <summary>
        /// Clone method
        /// Create a XPubContactModel object from existing one
        /// </summary>
        /// <returns>new XPubContactModel object</returns>
        public object Clone()
        {
            return new XPubContactModel
            { 
                Address = (XPubAddressModel)this.Address.Clone(), 
                BirthDate = this.BirthDate,
                Email = this.Email, 
                Prefix = this.Prefix, 
                Name = (XPubNameModel)this.Name.Clone(), 
                Photo = this.Photo, 
                Phone = this.Phone, 
                Notes = this.Notes, 
                Activity = this.Activity 
            };
        }
        #endregion
    }



}
