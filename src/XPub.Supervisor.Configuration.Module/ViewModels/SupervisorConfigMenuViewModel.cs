using XPub.Infrastructure.ViewModels;
using XPub.Resources;

namespace XPub.Supervisor.Configuration.Module.ViewModels
{
    #region SupervisorConfigMenuViewModel
    /// <summary>
    /// SupervisorConfigMenuViewModel object derived from the <see cref="MenuViewModel"/> class
    /// This class served at the view model menu item for the supervisor configuration screen
    /// </summary>
    public class SupervisorConfigMenuViewModel : MenuViewModel
    {


        #region Constructor
        /// <summary>
        /// SupervisorConfigMenuViewModel default constructor
        /// used to initialize base menu accessor properties
        /// </summary>
        public SupervisorConfigMenuViewModel()
        {

            Header = XPubResource.SupervisorConfigMenuItemDisplay;
            DisplayMemberPath = XPubResource.DisplayMemberPath; 
            NavigationPath = XPubResource.SupervisorConfigNavigationPath;
            ImageUri = @"Images/CreateJob.svg";
            GenerateMenu();
        }
        #endregion

        #region Utility Methods
        /// <summary>
        /// GenerateMenu method
        /// Used to generate sub menu items
        /// </summary>
        void GenerateMenu()
        {
        }
        #endregion

        #region ViewModelBase Implementation


        #endregion
    }
    #endregion
}

