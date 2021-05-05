using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XPub.Models.DataModels;
using XPub.Resources;
using XPub.Resources.Enums;
using System.Windows.Media;
using System.Windows.Media.Imaging;
namespace XPub.Infrastructure.ViewModels
{
    /// <summary>
    /// XPubEmployeeViewModel object derived from the <see cref="XPubViewModelBase"/>
    /// Serves as the view model for an employee
    /// </summary>
    public class XPubEmployeeViewModel : XPubViewModelBase
    {
        #region Property Accessors
        /// <summary>
        ///  Address Property Get/ Set Accessor
        ///  Provides address information
        /// </summary>
        /// <value>
        /// XPubAddressDataModel object
        /// </value>
        private XPubAddressDataModel _address;
        public XPubAddressDataModel Address 
        {
            get { return _address; }
            set { SetProperty(ref _address, value, XPubResource.PropAddress); } 
        }

        /// <summary>
        ///  BirthDate Property Get/ Set Accessor
        ///  Date of birth 
        /// </summary>
        /// <value>
        /// nullable DateTimeOffset object
        /// </value>
        private DateTimeOffset? _birthDate;
        public DateTimeOffset? BirthDate 
        { 
            get { return _birthDate; } 
            set { SetProperty(ref _birthDate, value, XPubResource.PropBirthDate); } 
        }


        /// <summary>
        ///  HireDate Property Get/ Set Accessor
        ///  Date of hire 
        /// </summary>
        /// <value>
        /// nullable DateTimeOffset object
        /// </value>
        private DateTimeOffset? _hireDate;
        public DateTimeOffset? HireDate 
        { 
            get { return _hireDate; }
            set { SetProperty(ref _hireDate, value, XPubResource.PropHireDate); } 
        }

        /// <summary>
        ///  Email Property Get/ Set Accessor
        ///  Email address 
        /// </summary>
        /// <value>
        /// string
        /// </value>
        private string  _email;
        public string Email 
        { 
            get { return _email; }
            set { SetProperty(ref _email, value, XPubResource.PropEmail); } 
        }

        /// <summary>
        ///  FirstName Property Get/ Set Accessor
        ///  FirstName of person  
        /// </summary>
        /// <value>
        /// string
        /// </value>
        private string _firstName;
        public string FirstName 
        { 
            get { return _firstName; } 
            set 
            { 
                SetProperty(ref _firstName, value, XPubResource.PropFirstName);
                RaiseFullNamePropertyChanged();
            } 
        }

        /// <summary>
        ///  LastName Property Get/ Set Accessor
        ///  LastName of person 
        /// </summary>
        /// <value>
        /// string
        /// </value>
        private string _lastName;
        public string LastName
        { 
            get { return _lastName; } 
            set 
            { 
                SetProperty(ref _lastName, value, XPubResource.PropLastName);
                RaiseFullNamePropertyChanged();
            }
        }

        /// <summary>
        ///  FullName Property Get/ Set Accessor
        ///  Fist and last name of person
        /// </summary>
        /// <value>
        /// string
        /// </value>

        public string FullName 
        { 
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        /// <summary>
        ///  HomePhone Property Get/ Set Accessor
        ///  Home phone number
        /// </summary>
        /// <value>
        /// string
        /// </value>
        private string _homePhone;
        public string HomePhone 
        { 
            get { return _homePhone; } 
            set { SetProperty(ref _homePhone, value, XPubResource.PropHomePhone); } 
        }

        /// <summary>
        ///  MobilePhone Property Get/ Set Accessor
        ///  Mobile phone number
        /// </summary>
        /// <value>
        /// string
        /// </value>
        private string _mobilePhone;
        public string MobilePhone
        { 
            get { return _mobilePhone; } 
            set { SetProperty(ref _mobilePhone, value, XPubResource.PropMobilePhone); } 
        }

        /// <summary>
        ///  PersonalProfile Property Get/ Set Accessor
        ///  Personal profile
        /// </summary>
        /// <value>
        /// string
        /// </value>
        private string _personalProfile;
        public string PersonalProfile 
        { 
            get { return _personalProfile; } 
            set { SetProperty(ref _personalProfile, value, XPubResource.PropPersonalProfile); } 
        }


        /// <summary>
        ///  XPubPersonStatusEnum Property Get/ Set Accessor
        ///  Current status 
        /// </summary>
        /// <value>
        /// XPubPersonStatusEnum enumeration value
        /// </value>
        private XPubPersonStatusEnum _status;
        public XPubPersonStatusEnum Status 
        { 
            get { return _status; } 
            set { SetProperty(ref _status, value, XPubResource.PropStatus); } 
        }

        /// <summary>
        ///  XPubPersonDepartmentEnum Property Get/ Set Accessor
        ///  Department 
        /// </summary>
        /// <value>
        /// XPubPersonDepartmentEnum enumeration value
        /// </value>
        private XPubPersonDepartmentEnum _department;
        public XPubPersonDepartmentEnum Department 
        { 
            get { return _department; } 
            set { SetProperty(ref _department, value, XPubResource.PropDepartment); } 
        }

        /// <summary>
        ///  AssignedTasks Property Get/ Set Accessor
        ///  Collection of assigned tasks 
        /// </summary>
        /// <value>
        /// Collection of XPubTaskDataModel objects
        /// </value>
        private ObservableCollection<XPubTaskDataModel> _assignedTasks;
        public ObservableCollection<XPubTaskDataModel> AssignedTasks 
        { 
            get { return _assignedTasks; } 
            set { SetProperty(ref _assignedTasks,value, XPubResource.PropAssignedTasks); }
        }



        /// <summary>
        ///  Evaluations Property Get/ Set Accessor
        ///  Collection of evaluations 
        /// </summary>
        /// <value>
        /// Collection of XPubEvaluationDataModel objects
        /// </value>
        private ObservableCollection<XPubEvaluationDataModel> _evaluations;
        public ObservableCollection<XPubEvaluationDataModel> Evaluations 
        { 
            get { return _evaluations; } 
            set { SetProperty(ref _evaluations, value, XPubResource.PropEvaluations); } 
        }

        #endregion

        /// <summary>
        ///  ProbationReason Property Get/ Set Accessor
        ///  Reason for probation
        /// </summary>
        /// <value>
        /// string
        /// </value>
        private string _probationReason;
        public string ProbationReason 
        { 
            get { return _probationReason; } 
            set { SetProperty(ref _probationReason, value,  XPubResource.PropProbationReason); } 
        }
        
        /// <summary>
        ///  Skype Property Get/ Set Accessor
        ///  Skype contact information
        /// </summary>
        /// <value>
        /// string
        /// </value>
        private string _skype;
        public string Skype
        { 
            get { return _skype; }
            set { SetProperty(ref _skype, value, XPubResource.PropSkype); } 
        }

        /// <summary>
        ///  Photo Property Get/ Set Accessor
        ///  Photo of person
        /// </summary>
        /// <value>
        /// ImageSource object
        /// </value>
        private ImageSource _photo;
        public ImageSource Photo 
        { 
            get { return _photo; } 
            set { SetProperty(ref _photo, value, XPubResource.PropPhoto); 
            } 
        }

        /// <summary>
        ///  Prefix Property Get/ Set Accessor
        ///  Person prefix salutation
        /// </summary>
        /// <value>
        /// XPubPersonPrefixEnum enumeration value
        /// </value>
        private XPubPersonPrefixEnum _prefix;
        public XPubPersonPrefixEnum Prefix 
        { 
            get { return _prefix; } 
            set { SetProperty(ref _prefix, value, XPubResource.PropPrefix); } 
        }

        /// <summary>
        ///  Error Property Get Accessor
        ///  Generates
        ///  an error string
        /// </summary>
        /// <value>
        /// string
        /// </value>
        public string Error
        {
            get
            {
                string error =
                    this["FirstName"] +
                    this["LastName"] +
                    this["Title"] +
                    this["MobilePhone"] +
                    this["Email"];
                if (!string.IsNullOrEmpty(error))
                    return "Please check inputted data.";
                return null;
            }
        }

        #region
        void RaiseFullNamePropertyChanged()
        {
            RaisePropertyChanged("FullName");
        }
        #endregion
        #region Constructors
        /// <summary>
        /// XPubEmployeeViewModel default constructor
        /// Initialize employee properties
        /// </summary>
        public XPubEmployeeViewModel()
        {
            Initialize();
        }
        #endregion
        #region Utility Demo Methods

        /// <summary>
        /// Initialize method
        /// Initializes employee's base accessor properties
        /// </summary>
        void Initialize()
        {
            Address = new XPubAddressDataModel();
            FirstName = "Leah";
            LastName = "Simpson";
            BirthDate = new DateTime(1983, 4, 19);
            Title = "Test Coordinator";
            Prefix = XPubPersonPrefixEnum.Mrs;
            HomePhone = "(562) 555-7372";
            MobilePhone = "(562) 559-5830";
            Email = "leahs@dx-email.com";
            Skype = "leahs_DX_skype";
            Department = XPubPersonDepartmentEnum.Engineering;
            Status = XPubPersonStatusEnum.Salaried;
            HireDate = new DateTime(2009, 2, 14);
            Photo = new BitmapImage(new Uri(
                @"pack://siteoforigin:,,,/Images/w03.jpg"));
            GenerateAssignedTasks();
            GenerateEvaluations();
        }

        /// <summary>
        /// GenerateAssignedTasks method
        /// Creates assigns task for employee
        /// </summary>
        void GenerateAssignedTasks()
        {
            AssignedTasks = new ObservableCollection<XPubTaskDataModel>();
            var employeeTask1 = new XPubTaskDataModel();
            employeeTask1.Priority = XPubTaskPriorityEnum.Normal;
            employeeTask1.DueDate = DateTime.Now + new TimeSpan(10, 10, 0, 0, 0);
            employeeTask1.Subject = string.Format("{0} QA Strategy Report", DateTime.Now.Year);
            employeeTask1.Description = string.Format("In final stages of the {0} R & D Report to Management.Need QA strategy report asap.Remember, {1} was a difficult year product quality-wise and we must step it up in {0}. Leah Simpson: Bart, my apologies about {1}.My report includes remedies to issues we encountered.", DateTime.Now.Year, DateTime.Now.Year - 1);
            employeeTask1.Completion = 100;
            AssignedTasks.Add(employeeTask1);

            var employeeTask2 = new XPubTaskDataModel();
            employeeTask2.Priority = XPubTaskPriorityEnum.Urgent;
            employeeTask2.DueDate = DateTime.Now + new TimeSpan(40, 10, 0, 0, 0);
            employeeTask2.Subject = "Review Training Course for any Commissions";
            employeeTask2.Description = "Leah, consider this most important item on your agenda. I need this new training material reviewed so it can be submitted to management. Leah Simpson: I only found a few spelling mistakes.";
            employeeTask2.Completion = 70;
            AssignedTasks.Add(employeeTask2);


            var employeeTask3 = new XPubTaskDataModel();
            employeeTask3.Priority = XPubTaskPriorityEnum.Low;
            employeeTask3.DueDate = DateTime.Now + new TimeSpan(80, 10, 0, 0, 0);
            employeeTask3.Subject = "Review New Training Material";
            employeeTask3.Description = "Just getting ready to push out some new training material for our customers so they can better understand how our product line fits together.Can I get a review of the content so I can send it out to the printer ? Leah Simpson: Nat, I've reviewed everything and it looks really nice.";
            employeeTask3.Completion = 55;
            AssignedTasks.Add(employeeTask3);

            var employeeTask4 = new XPubTaskDataModel();
            employeeTask4.Priority = XPubTaskPriorityEnum.High;
            employeeTask4.DueDate = DateTime.Now + new TimeSpan(95, 10, 0, 0, 0);
            employeeTask4.Subject = "Test New Automation App";
            employeeTask4.Description = "We are in a rush to ship this and you need to put all your energy behind finding bugs.If you do find bugs, use standard reporting mechanisms. We'll fix what we can as soon as we can.";
            employeeTask4.Completion = 40;
            AssignedTasks.Add(employeeTask4);

            var employeeTask5 = new XPubTaskDataModel();
            employeeTask5.Priority = XPubTaskPriorityEnum.Urgent;
            employeeTask5.DueDate = DateTime.Now + new TimeSpan(30, 10, 0, 0, 0);
            employeeTask5.Subject = "Email Test Report on New Products";
            employeeTask5.Description = "Leah, we cannot fix our products until we get the test report from you.Please send everything you have by email to me so I can distribute it in the engineering dept. Leah Simpson: Still collecting these";
            employeeTask5.Completion = 15;
            AssignedTasks.Add(employeeTask5);
        }

        /// <summary>
        /// GenerateEvaluations method
        /// Creates evaluation reports for the employee
        /// </summary>
        void GenerateEvaluations()
        {
            Random r = new Random();
            Evaluations = new ObservableCollection<XPubEvaluationDataModel>();
            for (int i = HireDate.Value.Year; i < DateTime.Now.Year; i++)
                Evaluations.Add(new XPubEvaluationDataModel() { CreatedOn = new DateTime(i, r.Next(1, 12), r.Next(1, 25)), Manager = "Bart Simpson", Subject = string.Format("{0} Employee Review", i) });
        }

        /// <summary>
        /// Indexer
        /// Used to produce an error string based on column name
        /// </summary>
        /// <param name="columnName">Column name</param>
        /// <returns>string</returns>
        public string this[string columnName]
        {
            get
            {
                if (columnName == XPubResource.PropFirstName && string.IsNullOrEmpty(FirstName))
                    return "The First Name field is required.";
                if (columnName == XPubResource.PropLastName && string.IsNullOrEmpty(LastName))
                    return "The Last Name field is required.";
                if (columnName == XPubResource.PropTitle && string.IsNullOrEmpty(Title))
                    return "The Title field is required.";
                if (columnName == XPubResource.PropMobilePhone && string.IsNullOrEmpty(MobilePhone))
                    return "The Mobile Phone field is required.";
                if (columnName == XPubResource.PropEmail && string.IsNullOrEmpty(Email))
                    return "The Email field is required.";
                return null;
            }
        }

 
        
        #endregion
    }
}
