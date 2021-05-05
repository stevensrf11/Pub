using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XPub.Interfaces.Models;

namespace XPub.Interfaces.Services
{
    /// <summary>
    /// IXPubService  interface model derived  from the interface <see cref="IXPub"/>
    /// </summary>
    public interface IXPubService : IXPub
    {
        #region Service Methods

        /// <summary>
        /// GetEmployeeInformationServiceAsync service
        /// An asynchronous task which retrieves employee information
        /// </summary>
        /// <returns></returns>
         Task<IXPubResultBaseModel> GetEmployeeInformationServiceAsync();

        #endregion
    }
}
