using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Prism.Events;
using XPub.Interfaces.Models;
using XPub.Interfaces.Services.Administration;
using XPub.Models.DataModels;
using XPub.Infrastructure;
using Prism.Regions;
using XPub.Resources.Enums;
using XPub.Infrastructure.Prism.Events;
using XPub.Resources;
using XPub.Infrastructure.ViewModels;

namespace XPub.Admin.HumanResources.Module.ViewModels
{
    /// <summary>
    /// AdminEmployeesViewModel view model concrete class derived from <see cref="XPubViewModelBase"/>
    /// View model class for the administration employee view
    /// </summary>
    /// <remarks> This class should be an aggravate of view models one for each display</remarks>

    public class AdminEmployeesViewModel : XPubViewModelBase
    {
        #region Fields
        /// <summary>
        /// _eventAggregator field interface
        /// Provides multicast publish/subscribe functionality.
        /// </summary>
        /// <value>
        /// IEventAggregator reference
        /// </value>
        private readonly IEventAggregator _eventAggregator;

        /// <summary>
        /// _xpubServiceAdmin field interface
        /// Contains references to administration services
        /// </summary>
        /// <value>
        /// IXPubServiceAdmin reference
        /// </value>
        private readonly IXPubServiceAdmin _xpubServiceAdmin;
        #endregion

       


        #region Property Accessors
        /// <summary>
        /// Message Property Set / Get Accessor Property
        /// </summary>
        /// <value>String</value>
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value, XPubResource.PropMessage); }
        }

        /// <summary>
        /// EmployeeViewModel Property  Get Accessor Property
        /// View model for an employee
        /// </summary>
        /// <value>XPubEmployeeViewModel reference</value>
        private XPubEmployeeViewModel _xPubEmployeeViewModel;
        public XPubEmployeeViewModel EmployeeViewModel
        {
            get { return _xPubEmployeeViewModel; }
        }
        ///<summary>
        /// Administrators Property Get/Set Accessor
        /// Collection of administrators information 
        /// </summary>
        /// <value>
        /// ObservableCollection of XPubEmployeeDataModel objects
        /// </value>
        private ObservableCollection<XPubEmployeeDataModel> _administrators;
        public ObservableCollection<XPubEmployeeDataModel> Administrators
        {
            get { return new ObservableCollection<XPubEmployeeDataModel>(EmployeeInformation.Where(x => x.Role == XPubResource.Administration).ToList()); }
        }

        /// <summary>
        /// Supervisors Property Get/Set Accessor
        /// Collection of supervisors information 
        /// </summary>
        /// <value>
        /// ObservableCollection of XPubEmployeeDataModel objects
        /// </value>
        private ObservableCollection<XPubEmployeeDataModel> _supervisors;
        public ObservableCollection<XPubEmployeeDataModel> Supervisors
        {
            get { return new ObservableCollection<XPubEmployeeDataModel>(EmployeeInformation.Where(x => x.Role == XPubResource.Supervisor).ToList()); }
        }


        /// <summary>
        /// Employees Property Get/Set Accessor
        /// Collection of employees information 
        /// </summary>
        /// <value>
        /// ObservableCollection of XPubEmployeeDataModel objects
        /// </value>
        private ObservableCollection<XPubEmployeeDataModel> _employees;
        public ObservableCollection<XPubEmployeeDataModel> Employees
        {
            get { return new ObservableCollection<XPubEmployeeDataModel>(EmployeeInformation.Where(x => x.Role == XPubResource.Employee).ToList()); }
        }

        /// <summary>
        /// EmployeeInformation Property Get/Set Accessor
        /// Collection of employee  information 
        /// </summary>
        /// <value>
        /// ObservableCollection of XPubEmployeeDataModel objects
        /// </value>
        private ObservableCollection<XPubEmployeeDataModel> _employeeInformation;
        public ObservableCollection<XPubEmployeeDataModel> EmployeeInformation
        {
            get { return _employeeInformation; }
            set { SetProperty(ref _employeeInformation, value, XPubResource.PropEmployeeInformation); }
        }





        #endregion

        #region Constructor
        /// <summary>
        /// AdminEmployeesViewModel parameterized constructor
        /// Used to initialize services and data information
        /// </summary>
        /// <param name="xpubServiceAdmin">Administration services</param>
        /// <param name="eventAggregator">Event aggregator</param>
        /// <param name="xPubEmployeeViewModel">Employee view model</param>
        public AdminEmployeesViewModel(IXPubServiceAdmin xpubServiceAdmin
            , IEventAggregator eventAggregator
            , XPubEmployeeViewModel xPubEmployeeViewModel)
        {
            _xPubEmployeeViewModel = xPubEmployeeViewModel;
            _eventAggregator = eventAggregator;
            _xpubServiceAdmin = xpubServiceAdmin;
            Message = "Admin Employee View";
            Task<ObservableCollection<XPubEmployeeDataModel>> task = Task.Run<ObservableCollection<XPubEmployeeDataModel>>(async () => await GetEmployeeInformationAsync());
            EmployeeInformation = task.Result;
        }
        #endregion

        #region IXPubServiceAdmin Services 
        /// <summary>
        /// GetEmployeeInformationAsync method
        /// An asynchronous method which collection of employee information
        /// </summary>
        /// <returns>Task with a collection of XPubEmployeeDataModel objects</returns>
        async Task<ObservableCollection<XPubEmployeeDataModel>> GetEmployeeInformationAsync()
        {
            var res = await _xpubServiceAdmin.GetEmployeeInformationServiceAsync();


            var recordModels = new ObservableCollection<XPubEmployeeDataModel>((res.ResultContent as IList<IXPubEmployeeModel>)
                .Where(y => y.Id.HasValue && y.ParentId.HasValue)
                .Select(x => new XPubEmployeeDataModel
                {
                    EmployeeId = x.Id,
                    ParentId = x.ParentId,
                    Role = string.IsNullOrEmpty(x.Role) ? string.Empty : x.Role.Trim(),

                    FirstName = string.IsNullOrEmpty(x.FirstName) ? string.Empty : x.FirstName.Trim(),
                    LastName = string.IsNullOrEmpty(x.LastName) ? string.Empty : x.LastName.Trim(),
                    FullName = string.IsNullOrEmpty(x.FullName) ? string.Empty : x.FullName.Trim(),


                    EmailAddress = string.IsNullOrEmpty(x.EmailAddress) ? string.Empty : x.EmailAddress.Trim(),
                    PhoneNumber = string.IsNullOrEmpty(x.PhoneNumber) ? string.Empty : x.PhoneNumber.Trim(),
                    Department = string.IsNullOrEmpty(x.Department) ? string.Empty : x.Department.Trim(),


                }).ToList());


            return recordModels;
        }
        #endregion

        #region ViewModelBase Navigation Implementation
        /// <summary>
        /// OnNavigatedTooverride method
        /// Called when the view screen is navigate to
        /// </summary>
        /// <param name="navigationContext">Provides access to the navigation URI, and to any parameters that were specified within it or externally..</param>
        /// <remarks> Make sure event aggregator has not been garbage collected before use</remarks>

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            var wt = new Tuple<WaitCursorEnums, XPubWaitCursorDataModel>(WaitCursorEnums.WaitCursorEnd, new XPubWaitCursorDataModel
            {
                ViewAppEnums = ViewEnums.AdminEmployee,
                WaitCursorEnum = WaitCursorEnums.WaitCursorEnd,
                Message = $"Admin Employee"
            }); ;

            _eventAggregator.GetEvent<WaitCursorEvent>().Publish(wt);
            #endregion

        }
    }
}
