using DevExpress.Mvvm;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using XPub.Resources;
using XPub.Resources.Enums;

namespace XPub.Infrastructure.Models
{
    ///  <summary>
    /// XPubTaskModel object derived from the <see cref="BindableBase"/> object
    /// and the <seealso cref="ICloneable"/>interface
    /// Contains task information
    /// </summary>
    public class XPubTaskModel : BindableBase, IDXDataErrorInfo
    {
        #region Fields
        
        DelegateCommand changeCompleteCommand;
        #endregion

        #region Constructors
        /// <summary>
        /// XPubTaskModel parametrized constructor
        /// </summary>
        /// <param name="subject">Task subject</param>
        /// <param name="category">Task category information</param>
        public XPubTaskModel(string subject, XPubTaskCategory category)
            : this(subject, category, DateTime.Now)
        {
        }
        /// <summary>
        /// XPubTaskModel parametrized base constructor
        /// </summary>
        /// <param name="subject">Task subject</param>
        /// <param name="category">Task category information</param>
        /// <param name="date">Task date</param>
        public XPubTaskModel(string subject, XPubTaskCategory category, DateTime date)
        {
            _subject = subject;
            _category = category;
            _createdDate = date;
        }
        #endregion

        #region Property Accessors

        ///  <summary>
        /// Priority Property Get  / Set Accessor
        /// Specifies current task priority
        /// Default value Medium 
        /// </summary>
        /// <value>XPubTaskPriority enumeration value</value>
         private XPubTaskPriority _priority = XPubTaskPriority.Medium;
       public XPubTaskPriority Priority
        {
            get { return _priority; }
            set { SetProperty(ref _priority, value, "Priority"); }
        }


        ///  <summary>
        /// PercentComplete Property Get  / Set Accessor
        /// Specifies percentage task is completed
        /// Default value is zero
        /// </summary>
        /// <value>integer</value >    
        private int _percentComplete = 0;
         public int PercentComplete
        {
            get { return _percentComplete; }
            set { SetProperty(ref _percentComplete, value < 0 ? 0 : value > 100 ? 100 : value, "PercentComplete", OnPercentCompleteChanged); }
        }

        ///  <summary>
        /// CreatedDate Property Get Accessor
        /// Specifies when the task was created
        /// </summary>
        /// <value>DateTime</value  
        private DateTime _createdDate;
        public DateTime CreatedDate { get { return _createdDate; } }

        ///  <summary>
        /// StartDate Property Get  / Set Accessor
        /// Specifies when the task was created
        /// Default value is zero
        /// </summary>
        /// <value>nullable datetime object</value >  
        DateTime? _startDate = null;
        public DateTime? StartDate
        {
            get { return _startDate; }
            set
            {
                SetProperty(ref _startDate, value, "StartDate");
                RaisePropertyChanged("Overdue");
            }
        }

        ///  <summary>
        /// StartDate Property Get  / Set Accessor
        /// Specifies when the task is due
        /// </summary>
        /// <value>nullable datetime object</value > 
        DateTime? _dueDate;
        public DateTime? DueDate
        {
            get { return _dueDate; }
            set
            {
                SetProperty(ref _dueDate, value, "DueDate");
                RaisePropertyChanged("Overdue");
            }
        }

        ///  <summary>
        /// CompletedDate Property Get  / Set Accessor
        /// Specifies when the task was completed
        /// </summary>
        /// <value>nullable datetime object</value > 
        DateTime? _completedDate;
        public DateTime? CompletedDate
        {
            get { return _completedDate; }
            set { SetProperty(ref _completedDate, value, "CompletedDate"); }
        }

        ///  <summary>
        /// PercentComplete Property Get  / Set Accessor
        /// Specifies the task's subject
        /// </summary>
        /// <value>string</value >
       private string _subject; 
        public string Subject
        {
            get { return _subject; }
            set { SetProperty(ref _subject, value, "Subject"); }
        }

        ///  <summary>
        /// Description Property Get  / Set Accessor
        /// Specifies the task's description
        /// </summary>
        /// <value>string</value >
        private string _description; 
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value, "Description"); }
        }

        ///  <summary>
        /// XPubTaskCategory Property Get  / Set Accessor
        /// Specifies the task's category
        /// </summary>
        /// <value>XPubTaskCategory enumeration value</value >
       private  XPubTaskCategory _category;
        public XPubTaskCategory Category
        {
            get { return _category; }
            set { SetProperty(ref _category, value, "Category"); }
        }

        ///  <summary>
        /// XPubTaskStatus Property Get  / Set Accessor
        /// Specifies the task's status
        /// Default value not started
        /// </summary>
        /// <value>XPubTaskStatus enumeration value</value >
        private XPubTaskStatus _status = XPubTaskStatus.NotStarted;
        public XPubTaskStatus Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value, "Status", OnStatusChanged); }
        }

        ///  <summary>
        /// AssignTo Property Get  / Set Accessor
        /// Specifies the task object
        /// </summary>
        /// <value>XPubContactModel object</value >
        private XPubContactModel _assignTo = null;
        public XPubContactModel AssignTo 
        {
            get { return _assignTo; }
            set { _assignTo = value; } 
        
        }

        ///  <summary>
        /// TimeDiff Property Get   Accessor
        /// Specifies the time span since task was created to the started date
        /// Default value not started
        /// <value>TimeSpan object</value >
        internal TimeSpan TimeDiff
        { 
            get { return (DateTime.Now - CreatedDate); } 
        }

        ///  <summary>
        /// Overdue Property Get  
        /// Specifies if the  task is past due
        /// </summary>
        /// <value>boolean</value >
        public bool Overdue
        {
            get
            {
                if (Status == XPubTaskStatus.Completed || !DueDate.HasValue) return false;
                DateTime dDate = DueDate.Value.Date.AddDays(1);
                if (DateTime.Now >= dDate) return true;
                return false;
            }
        }

        ///  <summary>
        /// Complete Property Get  / Set Accessor
        /// Specifies if task has been completed
        /// </summary>
        /// <value>boolean</value >
        public bool Complete
        {
            get { return Status == XPubTaskStatus.Completed; }
            set
            {
                Status = value ? XPubTaskStatus.Completed : XPubTaskStatus.NotStarted;
                RaisePropertiesChanged(new[] { "Complete", "FlagStatus" });
            }
        }
        ///  <summary>
        /// Icon Property Get  / Set Accessor
        /// Specifies if task has been completed or not
        /// </summary>
        /// <value>int</value >
        public int Icon 
        { 
            get { return Complete ? 0 : 1; } 
        }

        ///  <summary>
        /// FlagStatus Property Get  / Set Accessor
        /// Specifies if task current flag status
        /// </summary>
        /// <value>XPubFlagStatus enumeration value</value >
        public XPubFlagStatus FlagStatus
        {
            get
            {
                DateTime today = DateTime.Today;
                if (Complete) return XPubFlagStatus.Completed;
                if (!DueDate.HasValue) return XPubFlagStatus.NoDate;
                if (DueDate.Value.Date.Equals(today)) return XPubFlagStatus.Today;
                if (DueDate.Value.Date.Equals(today.AddDays(1))) return XPubFlagStatus.Tomorrow;
                DateTime thisWeekStart = DevExpress.Data.Filtering.Helpers.EvalHelpers.GetWeekStart(today);
                if (DueDate.Value.Date >= thisWeekStart && DueDate.Value.Date < thisWeekStart.AddDays(7)) return XPubFlagStatus.ThisWeek;
                if (DueDate.Value.Date >= thisWeekStart.AddDays(7) && DueDate.Value.Date < thisWeekStart.AddDays(14)) return XPubFlagStatus.NextWeek;
                return XPubFlagStatus.Custom;
            }
        }

        ///  <summary>
        /// ChangeCompleteCommand Property Get  Accessor
        /// Specifies if task change complete delegate command
        /// </summary>
        /// <value>DelegateCommande</value 
        public DelegateCommand ChangeCompleteCommand
        {
            get
            {
                if (changeCompleteCommand == null)
                    changeCompleteCommand = new DelegateCommand(ChangeComplete);
                return changeCompleteCommand;
            }
        }        
        #endregion


        #region Utility Methods
        /// <summary>
        /// OnPercentCompleteChanged method
        /// Updates the status based on percent completed
        /// </summary>
        void OnPercentCompleteChanged()
        {
            if (PercentComplete == 100)
                Status = XPubTaskStatus.Completed;
            else if (PercentComplete > 0)
                Status = XPubTaskStatus.InProgress;
        }


        /// <summary>
        /// OnStatusChanged method
        /// Updates the PercentComplete,CompletedDate,  and DueDate properties
        /// based on status changes
        /// </summary>
        void OnStatusChanged()
        {
            if (Status == XPubTaskStatus.Completed)
            {
                PercentComplete = 100;
                CompletedDate = DateTime.Now;
            }
            else
                CompletedDate = null;
            if (Status == XPubTaskStatus.NotStarted)
                PercentComplete = 0;
            if (Status == XPubTaskStatus.InProgress && PercentComplete == 100)
                PercentComplete = 75;
            if (Status == XPubTaskStatus.Deferred || Status == XPubTaskStatus.WaitingOnSomeoneElse)
                DueDate = null;
            RaisePropertyChanged("Complete");
        }

        /// <summary>
        /// ChangeComplete method
        /// Updates the tasks complete property
        /// </summary>
        void ChangeComplete() { Complete = !Complete; }

        /// <summary>
        /// Assign method
        /// Updates the tasks base properties from the task parameter
        /// </summary>
        /// <param name="task">XPubTaskModel object</param>
        public void Assign(XPubTaskModel task)
        {
            _subject = task.Subject;
            _priority = task.Priority;
            _percentComplete = task.PercentComplete;
           _createdDate = task.CreatedDate;
            _startDate = task.StartDate;
            _dueDate = task.DueDate;
            _completedDate = task.CompletedDate;
            _description = task.Description;
            _category = task.Category;
            _status = task.Status;
            _assignTo = task.AssignTo;
            RaisePropertiesChanged(string.Empty);
        }


        #endregion

        #region ICloneable Implementation
        ///  <summary>
        /// Clone method
        /// Create a new XPubTaskModel from the existing one
        /// </summary>
        /// <returns>new initialized XPubNameModel</value>
        public XPubTaskModel Clone()
        {
            XPubTaskModel task = new XPubTaskModel(this.Subject, this.Category);
            task.Assign(this);
            return task;
        }
        #endregion

        #region IDXDataErrorInfo Implementation
        void IDXDataErrorInfo.GetError(ErrorInfo info) { }

        void IDXDataErrorInfo.GetPropertyError(string propertyName, ErrorInfo info)
        {
            if (propertyName == "DueDate")
            {
                if ((DueDate.HasValue && StartDate.HasValue) && DueDate < StartDate)
                    SetErrorInfo(info, XPubErrorResource.DueDateError, ErrorType.Critical);
                if (!DueDate.HasValue && Status == XPubTaskStatus.InProgress)
                    SetErrorInfo(info, XPubErrorResource.DueDateWarning, ErrorType.Warning);
            }
        }
        void SetErrorInfo(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info, string errorText, ErrorType errorType)
        {
            info.ErrorText = errorText;
            info.ErrorType = errorType;
        }
        #endregion
    }

}
