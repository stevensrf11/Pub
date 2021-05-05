using XPub.Models.DataModels;

namespace XPub.Infrastructure.ViewModels
{
    /// <summary>
    /// CreateJobPopViewModel object derived from <see cref=" DevExpress.Mvvm.ViewModelBase"/> object
    /// Used as view model for embedded window used for creating jobs
    /// </summary>
    public class CreateJobPopViewModel : DevExpress.Mvvm.ViewModelBase
    {
        #region Property Accessors
        /// <summary>
        /// CreateJobPopUpData Property Get / Set Accessor
        /// Specifies the data model used by the view model
        /// </summary>
        /// <value> XPubCreateJobPopUpDataModel reference</value>
        public XPubCreateJobPopUpDataModel CreateJobPopUpData { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// CreateJobPopViewModel default constructor
        /// Create a new data model 
        /// </summary>
        public CreateJobPopViewModel()
        {
            CreateJobPopUpData = new XPubCreateJobPopUpDataModel();
        }
        #endregion
    }
}
