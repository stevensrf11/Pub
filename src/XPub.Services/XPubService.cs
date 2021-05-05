using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XPub.Interfaces.Models;
using XPub.Interfaces.Services;
using XPub.Models;
using XPub.Services.WorkFlows;

namespace XPub.Services
{
    /// <summary>
    /// XPubService   concrete class service derived from the interface  <see cref="IXPubService"/>
    /// Base class for XOub Services
    /// </summary>
    public class XPubService : IXPubService
    {
        #region IXPubServiceAdmin Services
        #region Service Methods

        /// <summary>
        /// GetEmployeeInformationServiceAsync service
        /// An asynchronous task which retrieves employee information
        /// </summary>
        /// <returns></returns>
        public async Task<IXPubResultBaseModel> GetEmployeeInformationServiceAsync()
        {
            var retList = new XPubResultBaseModel();
            retList.ResultOperation = Resources.Enums.XPubResultBaseOperationEnums.GetEmployeeInformation;
            retList.Errors = new List<string>();
            try
            {
                retList.ResultContent = await new XPubWorkFlows().GetEmployeeInformationWorkFlowAsync();
                retList.ResultSuccess = true;

            }
            catch (Exception ex)
            {
                retList.HasErrors = true;
                retList.Errors.Add(ex.Message);
                retList.ResultContent = new List<IXPubEmployeeModel>();
            }
            return retList;
        }
        #endregion

        #endregion 

    }
}
