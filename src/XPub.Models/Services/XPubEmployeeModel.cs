using System;
using System.Collections.Generic;
using System.Text;
using XPub.Interfaces.Models;

namespace XPub.Models.Services
{
    /// <summary>
    /// XPubEmployeeModel  model concrete class derived from the class  <see cref="XPubModel"/>
    /// , and the interface <seealso cref="IXPubEmployeeModel"/>
    /// Contains employee information
    /// </summary>
    public class XPubEmployeeModel: XPubModel
        , IXPubEmployeeModel
    {
        #region Property Accessors


        /// <summary>
        /// FirstName Property Get  Set Accessor
        /// Employee's First Name
        /// </summary>
        ///<value>
        /// string
        ///</value>
        public string FirstName { get; set; }


        /// <summary>
        /// LastName Property Get  Set Accessor
        /// Employee's Last Name
        /// </summary>
        ///<value>
        /// string
        ///</value>
        public string LastName { get; set; }

        /// <summary>
        /// FullName Property Get  Set Accessor
        /// Employee's Full Name
        /// </summary>
        ///<value>
        /// string
        ///</value>
        public string FullName { get; set; }


        /// <summary>
        /// EmailAddress Property Get  Set Accessor
        /// Employee's Email Address
        /// </summary>
        ///<value>
        /// string
        ///</value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Role Property Get  Set Accessor
        /// Employee's Role
        /// </summary>
        ///<value>
        /// string
        ///</value>
        public string Role { get; set; }

        /// <summary>
        /// ParentId Get  Set Accessor
        /// Employee's parent identification  
        /// </summary>
        ///<value>
        /// nullable long
        ///</value>
        public long? ParentId { get; set; }

        /// <summary>
        /// PhoneNumber Property Get  Set Accessor
        /// Employee's Phone Number
        /// </summary>
        ///<value>
        /// string
        ///</value>
        public string PhoneNumber { get; set; }


        /// <summary>
        /// Department Property Get  Set Accessor
        /// Employee'sDepartment
        /// </summary>
        ///<value>
        /// string
        ///</value>
        public string Department { get; set; }


        #endregion

    }
}
