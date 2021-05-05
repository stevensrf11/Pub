using System;
using XPub.Models.DataModels;

namespace XPub.Infrastructure.Models
{
    /// <summary>
    /// XPubAddressModel object derived from the <see cref="XPubAddressDataModel"/> object
    /// Provides the address model
    /// </summary>
    public class XPubAddressModel : XPubAddressDataModel
    {
        #region PropertyAccessors
        /// <summary>
        /// AddressLine Property Get Set Accessor
        /// Contains the physical location (street address, po box, etc)
        /// </summary>
        /// <value> string</value>
        string addressLine;
        public string AddressLine
        {
            get { return addressLine; }
            set
            {
                if (addressLine != value)
                {
                    addressLine = value;
                    RaisePropertyChanged("AddressLine");
                }
            }
        }

        /// <summary>
        /// State Property Get Set Accessor
        /// Contains the state
        /// </summary>
        /// <value> string</value>
        string state;
        public string State
        {
            get { return state; }
            set
            {
                if (state != value)
                {
                    state = value;
                    RaisePropertyChanged("State");
                }
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// XPubAddressModel Default constructor
        /// </summary>
        public XPubAddressModel() { }

        /// <summary>
        /// XPubAddressModelinternal parametrized constructor
        /// Used to initialize property accessors
        /// </summary>
        /// <param name="addressString"></param>
        internal XPubAddressModel(string addressString)
        {
            try
            {
                string[] lines = addressString.Split(',');
                this.AddressLine = lines[0].Trim();
                this.City = lines[1].Trim();
                this.State = lines[2].Trim().Substring(0, 2);
                string temp = lines[2].Trim();
                this.ZipCode = temp.Substring(3, temp.Length - 3);
            }
            catch { }
        }
        #endregion

        #region Object Overrides
        /// <summary>
        /// ToString method override
        /// Used to form a complete address string
        /// </summary>
        /// <returns> Full address string</returns>
        public override string ToString()
        {
            return GetAddressFullString(Environment.NewLine);
        }
        #endregion

        #region Utility Methods
        /// <summary>
        /// GetAddressFullString method 
        /// Used to form a complete address string
        /// </summary>
        /// <param name="separator">Septation string to use in full address string </param>
        /// <returns> Full address string</returns>
        public string GetAddressFullString(string separator)
        {
            return string.Format("{0}{1}{2}{3}{4}", AddressLine, separator, GetFormatString(City), GetFormatString(State, false), GetFormatString(ZipCode, false));
        }

        /// <summary>
        /// GetFormatString method
        /// Used to format the address name
        /// </summary>
        /// <param name="name">String to format</param>
        /// <param name="addComma">Comma separator boolean</param>
        /// <returns></returns>
        string GetFormatString(string name, bool addComma = true)
        {
            if (string.IsNullOrEmpty(name))
                return string.Empty;
            string format = addComma ? "{0}, " : "{0} ";
            return string.Format(format, name);
        }
        /// <summary>
        /// Assign method
        /// Updates address's properties
        /// </summary>
        /// <param name="address"></param>
        public void Assign(XPubAddressModel address)
        {
            this.AddressLine = address.AddressLine;
            this.State = address.State;
            this.City = address.City;
            this.ZipCode = address.ZipCode;
        }

        /// <summary>
        /// Clone method 
        /// Use to create new XPubAddressModel object from the current 
        /// </summary>
        /// <returns>XPubAddressModel object</returns>
        public object Clone()
        {
            return new XPubAddressModel() 
            { 
                AddressLine = this.AddressLine,
                City = this.City, 
                State = this.State, 
                ZipCode =
                this.ZipCode 
            };
        }
        #endregion
    }
}
