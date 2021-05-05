using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XPub.Interfaces.Models;
using XPub.Interfaces.Services.Administration;
using XPub.Models;
using XPub.Services.WorkFlows;

namespace XPub.Services.Administration
{
    /// <summary>
    /// XPubServiceAdmin  concrete class derived from the class  <see cref="XPubService"/>
    /// , and the interface <seealso cref="IXPubServiceAdmin"/>
    /// Contains XOub administration services
    /// </summary>
    public class XPubServiceAdmin : XPubService
        , IXPubServiceAdmin
    {

        #region IXPubServiceAdmin Services
        #region Service Methods

        /// <summary>
        /// GetFileRecordInformationServiceAsync service
        /// An asynchronous task which retrieves record file information
        /// </summary>
        /// <returns></returns>
        public async Task<IXPubResultBaseModel> GetFileRecordInformationServiceAsync()
        {
            var retList = new XPubResultBaseModel();
            retList.ResultOperation = Resources.Enums.XPubResultBaseOperationEnums.GetFileRecordInformation;
            retList.Errors = new List<string>();
            try
            {
                retList.ResultContent = await new XPubWorkFlows().GetFileRecordInformationWorkFlowAsync();
                retList.ResultSuccess = true;
               
            }
            catch(Exception ex )
            {
                retList.HasErrors = true;
                retList.Errors.Add(ex.Message);
                retList.ResultContent = new List<IXPubRecordModel>();
            }
            return retList;
        }
        #endregion

        #endregion 
    }


}
