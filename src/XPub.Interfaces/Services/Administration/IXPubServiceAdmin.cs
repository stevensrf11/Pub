using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XPub.Interfaces.Models;

namespace XPub.Interfaces.Services.Administration
{
    /// <summary>
    /// IXPubServiceAdmin  interface model derived  from the interface <see cref="IXPubService"/>
    /// Contains administration services stubs
    /// </summary>
    public interface IXPubServiceAdmin : IXPubService
    {
        #region Service Methods

        /// <summary>
        /// GetFileRecordInformationServiceAsync service
        /// An asynchronous task which retrieves record file information
        /// </summary>
        /// <returns></returns>
        Task<IXPubResultBaseModel> GetFileRecordInformationServiceAsync();
        #endregion

    }
}
