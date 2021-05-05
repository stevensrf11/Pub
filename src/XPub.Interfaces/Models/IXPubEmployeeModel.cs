using System;
using System.Collections.Generic;
using System.Text;

namespace XPub.Interfaces.Models
{
    /// <summary>
    /// IXPubEmployeeModel  interface model derived  from the interface <see cref="IXPubModel"/>
    ///  Stores employee information
    /// </summary>
    public interface IXPubEmployeeModel : IXPubModel
    {
        #region Property Accessors


        /// <summary>
        /// FirstName Property Get  Set Accessor
        /// Employee's First Name
        /// </summary>
        ///<value>
        /// string
        ///</value>
        string FirstName { get; set; }


        /// <summary>
        /// LastName Property Get  Set Accessor
        /// Employee's Last Name
        /// </summary>
        ///<value>
        /// string
        ///</value>
        string LastName { get; set; }

        /// <summary>
        /// FullName Property Get  Set Accessor
        /// Employee's Full Name
        /// </summary>
        ///<value>
        /// string
        ///</value>
        string FullName { get; set; }


        /// <summary>
        /// EmailAddress Property Get  Set Accessor
        /// Employee's Email Address
        /// </summary>
        ///<value>
        /// string
        ///</value>
        string EmailAddress { get; set; }

        /// <summary>
        /// Role Property Get  Set Accessor
        /// Employee's Role
        /// </summary>
        ///<value>
        /// string
        ///</value>
        string Role { get; set; }

        /// <summary>
        /// PhoneNumber Property Get  Set Accessor
        /// Employee's Phone Number
        /// </summary>
        ///<value>
        /// string
        ///</value>
        string PhoneNumber { get; set; }


        /// <summary>
        /// Department Property Get  Set Accessor
        /// Employee'sDepartment
        /// </summary>
        ///<value>
        /// string
        ///</value>
        string Department { get; set; }


        /// <summary>
        /// ParentId Get  Set Accessor
        /// Employee's parent identification   
        /// </summary>
        ///<value>
        /// nullable long
        ///</value>
         long? ParentId { get; set; }






        #endregion

    }
}
