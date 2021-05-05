using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using XPub.Infrastructure;
using XPub.Infrastructure.Prism.Events;
using XPub.Infrastructure.ViewModels;
using XPub.Interfaces.Models;
using XPub.Interfaces.Models.DataModels;
using XPub.Interfaces.Services.Administration;
using XPub.Models.DataModels;
using XPub.Resources;
using XPub.Resources.Enums;
namespace XPub.Admin.Configuration.Module.ViewModels
{
    /// <summary>
    /// AdminConfigCreateJobViewModel view model concrete class derived from <see cref="XPubViewModelBase"/>
    /// View model class for the administration configuration view
    /// </summary>
    /// <remarks> This class should be an aggravate of view models one for each display</remarks>
    public class AdminConfigCreateJobViewModel : XPubViewModelBase
    {
        #region Fields

        /// <summary>
        /// _eventAggregator Field
        /// Used in broadcasting and subscribing to events
        /// </summary> 
        /// <value>IEventAggregator reference </value>
        private readonly IEventAggregator _eventAggregator;
     
        /// <summary>
        /// _xpubServiceAdmin field interface
        /// Contains references to administration services
        /// </summary>
        private readonly IXPubServiceAdmin _xpubServiceAdmin;
        #endregion

       
        #region DelegateCommands
        /// <summary>
        /// GotFocusCommand Delegate command
        /// Command for the GotFocus event
        /// </summary
        private DelegateCommand<object> _gotFocusCommand;
        public DelegateCommand<object> GotFocusCommand => _gotFocusCommand ?? (_gotFocusCommand = new DelegateCommand<object>(ExecuteGotFocusCommand));

        /// <summary>
        /// LostFocusCommand Delegate command
        /// Command for the LostFocus event
        /// </summary
        private DelegateCommand<object> _lostFocusCommand;
        public DelegateCommand<object> LostFocusCommand => _lostFocusCommand ?? (_lostFocusCommand = new DelegateCommand<object>(ExecuteLostFocusCommand));

        /// <summary>
        /// CreateRecordJobCommand Delegate command
        /// Command for the when the create job pop window command event
        /// </summary>
        private DelegateCommand<object> __createRecordJobCommand;
        public DelegateCommand<object> CreateRecordJobCommand => __createRecordJobCommand ?? (__createRecordJobCommand = new DelegateCommand<object>(ExecuteCreateRecordJobCommand));

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
        /// CreateJobPopUp Property Set / Get Accessor Property
        /// View model for create job pop window
        /// </summary>
        /// <value>CreateJobPopViewModel reference</value>
        private CreateJobPopViewModel _createJobPopUp;
        public CreateJobPopViewModel CreateJobPopUp
        {
            get { return _createJobPopUp; }
            set { SetProperty(ref _createJobPopUp, value, XPubResource.PropCreateJobPopUp); }
        }


        /// <summary>
        /// RecordModels Property Get/Set Accessor
        /// Collection of record information 
        /// </summary>
        /// <value>
        /// ObservableCollection of IXPubConfigRecordDataModel references
        /// </value>
        private ObservableCollection<IXPubConfigRecordDataModel> _recordModels  ;
        public ObservableCollection<IXPubConfigRecordDataModel> RecordModels
        {
            get { return _recordModels; }
            set { SetProperty(ref _recordModels, value, XPubResource.PropRecordModels); }
        }


        /// <summary>
        /// RecordModels Property Get/Set Accessor
        /// Collection of record information 
        /// </summary>
        /// <value>
        /// ObservableCollection of IXPubConfigRecordDataModel references
        /// </value>
        private ObservableCollection<XPubCreateJobRecordFileDataModel> _createRecordJobs;
        public ObservableCollection<XPubCreateJobRecordFileDataModel> CreateRecordJobs
        {
            get { return _createRecordJobs; }
            set { SetProperty(ref _createRecordJobs, value, XPubResource.PropCreateRecordJobs); }
        }
        

        /// <summary>
        /// CreateJobTitle Property Get/Set Accessor
        /// Title of create job
        /// </summary>
        /// <value>
        /// string
        /// </value>
        private String _createJobTitle;
        public String CreateJobTitle
        {
            get { return _createJobTitle; }
            set { SetProperty(ref _createJobTitle, value, XPubResource.PropCreateJobTitle); }
        }

        #endregion
   
        #region Constructor
        /// <summary>
        /// AdminConfigCreateJobViewModel constructor
        /// </summary>
        /// <param name="xpubServiceAdmin">XPub administration service reference</param>
        /// <param name="eventAggregator"> Event aggregator reference</param>
        public AdminConfigCreateJobViewModel(IXPubServiceAdmin xpubServiceAdmin
            ,  IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Message = "Admin Create Job View";
            _xpubServiceAdmin = xpubServiceAdmin;
            CreateJobTitle = $"Create Job";
            CreateJobPopUp = new CreateJobPopViewModel();
            Task<ObservableCollection<IXPubConfigRecordDataModel>> task = Task.Run <ObservableCollection<IXPubConfigRecordDataModel>> (async () => await GetFileRecordInformationAsynv());
            //Task<LogEntity> task = Task.Run<LogEntity>(async () => await GetLogAsync());

             RecordModels = task.Result;
            var s = RecordModels.GroupBy(p => p.RecordFile)
                                  .Select(g => g.First())
                                  .ToList();
            CreateRecordJobs = new ObservableCollection<XPubCreateJobRecordFileDataModel>(
                                  s.Select(x => new XPubCreateJobRecordFileDataModel
                                  {
                                      RecordFile = x.RecordFile,
                                      RecordFileParameter = x.RecordFile,
                                      DateReceived = x.DateReceived,
                                      FileName = x.FileName,
                                      IDString= $"{x.RecordFile} {x.DateReceived.Value.ToString("MM-dd-yyyy")}"
                                  }).ToList());
            //CreateRecordJobs=new ObservableCollection<XPubCreateJobRecordFileDataModel>( RecordModels.GroupBy(p => p.RecordFile)
            //                      .Select(g => g.First())
            //                      .ToList().Select(x=> new XPubCreateJobRecordFileDataModel
            //                      {
            //                          RecordFile=x.RecordFile,
            //                          RecordFileParameter=x.RecordFile
            //                      }).ToList());

       

        }
        #endregion

        #region IXPubServiceAdmin Services 
        /// <summary>
        /// GetFileRecordInformationAsynv asynchronous method
        /// Used to get record file information 
        /// </summary>
        /// <returns>task of collection of IXPubConfigRecordDataModel references</returns>
        async Task<ObservableCollection<IXPubConfigRecordDataModel>>  GetFileRecordInformationAsynv()
        {


            var res =await  _xpubServiceAdmin.GetFileRecordInformationServiceAsync();


            var recordModels = new ObservableCollection<IXPubConfigRecordDataModel>((res.ResultContent as IList<IXPubRecordModel>)
                .Select(x => new XPubConfigRecordDataModel
                {
                    RecordFile = x.IDString.Trim(),
                    FileName = x.FileName.Trim(),

                    FileType = x.FileType.Trim(),
                    DateReceived = x.DateReceived
                    ,
                    FileSize= x.FileSize
                }).Cast<IXPubConfigRecordDataModel>().ToList());

       
            //RecordModels = new ObservableCollection(
            //    (res.ResultContent as IList<IXPubRecordModel>)
            //    .Select(x=>new XPubConfigRecordDataModel {
            //        RecordFile= x.IDString})
            //    ;
        
            return recordModels;
        }
        #endregion

        #region Execute / CanExecute Properties
        /// <summary>
        ///  ExecuteLostFocusCommand Property
        ///  Execute command for the LostFocusCommand Delegate Command
        /// </summary>
        /// <param name="eventArgs">LostFocus event arguments</param>
        /// <remarks> Property is coded for asynchronous action but with out an await the property will run synchronously</remarks>
        private async void ExecuteLostFocusCommand(object eventArgs)
        {
        }
        /// <summary>
        ///  ExecuteGotFocusCommand Property
        ///  Execute command for the GotFocusCommand Delegate Command
        /// </summary>
        /// <param name="eventArgs">GorFocus event arguments</param>
        /// <remarks> Property is coded for asynchronous action but with out an await the property will run synchronously</remarks>
        private async void ExecuteGotFocusCommand(object eventArgs)
        {
            

        }

        /// <summary>
        /// ExecuteCreateRecordJobCommand Execute handler
        /// Create record job execute handler
        /// </summary>
        /// <param name="eventArgs"> Record file name command parameter</param>
        /// <remarks> Property is coded for asynchronous action but with out an await the property will run synchronously</remarks>
        private async void ExecuteCreateRecordJobCommand(object eventArgs)
        {


        }


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
                ViewAppEnums = ViewEnums.AdminCreateJob,
                WaitCursorEnum = WaitCursorEnums.WaitCursorEnd,
                Message = $"Admin create job"
            }); ;
            _eventAggregator.GetEvent<WaitCursorEvent>().Publish(wt);
        }
        #endregion

    }
}
