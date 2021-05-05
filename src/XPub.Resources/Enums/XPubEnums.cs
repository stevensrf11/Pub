using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XPub.Resources.Attributes;

namespace XPub.Resources.Enums
{
    /// <summary>
    /// ResultBaseOperationEnums enumerations
    /// Describes type of operation
    /// </summary>
    public enum XPubResultBaseOperationEnums
    {
        [Description("No Operation")] None = 0,
        [Description("Get Connection Information From Server")] GetFileRecordInformation = 1,
        [Description("Get Employee  Information From Server")] GetEmployeeInformation = 2,

    }

    /// <summary>
    /// WaitCursor
    /// Describes type of operation
    /// </summary>
    public enum WaitCursorEnums
    {
        [Description("No Operation")] None = 0,
        [Description("Started wait cursor")] WaitCursorStart = 1,
        [Description("End wait cursor")] WaitCursorEnd = 2,

    }

    public enum ViewEnums
    {
        [Description("No Operation")] None = 0,
        [Description("Shell view")] Shell = 1,
        [Description("Admin Create Job")] AdminCreateJob = 2,
        [Description("Admin Employee")] AdminEmployee  ,
        [Description("Super Job Management")] SuperJobManagement,
        [Description("Employee Assigned Work")] EmployeeAssignedWork,

        End

    }


    /// <summary>
    /// MarkUpStateEnum
    /// Describes background state and state color status record file a  for the supervisor job management module
    /// </summary>
    public enum MarkUpStateEnum
    {
        [Description("White")]
        None = 0,

        [Description("Green")]
        Default,
        [Description("Orange")]
        ChangeReview,
        [Description("Yellow")]
        MarkUp,
        [Description("Yellow")]
        Proof,
        [Description("Green")]
        ProofRead,
        [Description("Green")]
        ProofReading,
        [Description("Yellow")]
        StructuralMarkup,

    }

    /// <summary>
    /// MarkUpSelectorEnum
    /// Describes the template used to display the status record file a  for the supervisor job management module
    /// </summary>
    public enum MarkUpSelectorEnum
    {
        None = 0,
        MarkUpState,
        MarkUpSection
    }
    public enum XPubGridModuleNavigationParameter { Default, NewItem }

    public enum XPubTaskStatus { NotStarted, InProgress, Completed, WaitingOnSomeoneElse, Deferred };
    
    public enum XPubTaskCategory
    {
        [XPubImage("pack://siteoforigin:,,,/Images/Tasks/Category_HouseChores.svg")]
        HouseChores,
        [XPubImage("pack://siteoforigin:,,,/Images/Tasks/Category_Shopping.svg")]
        Shopping,
        [XPubImage("pack://siteoforigin:,,,/Images/Tasks/Category_Work.svg")]
        Work
    };
    public enum XPubFlagStatus { Today, Tomorrow, ThisWeek, NextWeek, NoDate, Custom, Completed };

    public enum XPubTaskPriority
    {
        [XPubImage("pack://siteoforigin:,,,/Images/Tasks/Priority_High.svg")]
        Low = 0,
        Medium = 1,
        [XPubImage("pack://siteoforigin:,,,/Images/Tasks/Priority_Low.svg")]
        High = 2
    };
}
