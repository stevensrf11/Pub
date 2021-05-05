using XPub.Infrastructure.ViewModels;
using XPub.Resources;
namespace XPub.Supervisor.JobManagement.Module.ViewModels
{

    /// <summary>
    /// SupervisorJobManagementMenuViewModel object derived from the <see cref="MenuViewModel"/> class
    /// This class served at the view model menu item for the supervisor job management screen
    /// </summary>
    public class SupervisorJobManagementMenuViewModel : MenuViewModel
    {

        #region Constructor
        /// <summary>
        /// SupervisorJobManagementMenuViewModel default constructor
        /// used to initialize base menu accessor properties
        /// </summary>
        public SupervisorJobManagementMenuViewModel()
        {

            Header = XPubResource.SupervisorJobManagementMenuItenDisplay;
            DisplayMemberPath = XPubResource.DisplayMemberPath;
            NavigationPath = XPubResource.SupervisorJobManagementNavigationPath;
            ImageUri = @"Images/JobManagement.svg";

        }
        #endregion
    }
}
