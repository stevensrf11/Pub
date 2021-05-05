using System;
using System.Collections.Generic;
using System.Text;
using XPub.Resources.Attributes;
using XPub.Resources.Utilities;

namespace XPub.Resources.Enums
{
    /// <summary>
    /// XPubPersonPrefixEnum enumeration values
    /// Links image to a person's prefix salutation
    /// </summary>
    public enum XPubPersonPrefixEnum
    {
        None,
        [XPubImage(XPubStringConstants.ImagesPath + "Doctor.svg")]
        Dr,
        [XPubImage(XPubStringConstants.ImagesPath + "Customers.svg")]
        Mr,
        [XPubImage(XPubStringConstants.ImagesPath + "Mr.svg")]
        Ms,
        [XPubImage(XPubStringConstants.ImagesPath + "Miss.svg")]
        Miss,
        [XPubImage(XPubStringConstants.ImagesPath + "Mrs.svg")]
        Mrs,
        [XPubImage(XPubStringConstants.ImagesPath + "Professor.svg")]
        Prof
    }

    /// <summary>
    /// XPubPersonStatusEnum enumerations values
    /// Represents a person's status
    /// </summary>
    public enum XPubPersonStatusEnum
    {
        Salaried,
        Commission,
        Terminated,
        OnLeave
    }

    /// <summary>
    /// XPubPersonDepartmentEnum enumerations values
    /// Represents a  department
    /// </summary>
    public enum XPubPersonDepartmentEnum { Sales, Support, Shipping, Engineering, HumanResources, Management, IT }

    /// <summary>
    /// XPubStateEnum enumerations values
    /// Represents a States two letter abbreviation
    /// </summary>
    public enum XPubStateEnum { CA, AR, AL, AK, AZ, CO, CT, DE, DC, FL, GA, HI, ID, IL, IN, IA, KS, KY, LA, ME, MD, MA, MI, MN, MS, MO, MT, NE, NV, NH, NJ, NM, NY, NC, OH, OK, OR, PA, RI, SC, SD, TN, TX, UT, VT, VA, WA, WV, WI, WY, ND }

    /// <summary>
    /// XPubTaskPriorityEnum enumerations values
    /// Represents a task enumeration to a corresponding image
    /// </summary>
    public enum XPubTaskPriorityEnum
    {
        [XPubImage(XPubStringConstants.ImagesPath + "Outlook Inspired/LowPriority.svg")]
        Low,
        [XPubImage(XPubStringConstants.ImagesPath + "Outlook Inspired/NormalPriority.svg")]
        Normal,
        [XPubImage(XPubStringConstants.ImagesPath + "Outlook Inspired/MediumPriority.svg")]
        High,
        [XPubImage(XPubStringConstants.ImagesPath + "Outlook Inspired/HighPriority.svg")]
        Urgent
    }
}
