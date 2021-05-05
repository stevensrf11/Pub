using XPub.Infrastructure.ViewModels;
using XPub.Resources;

namespace XPub.Admin.Configuration.Module.ViewModels
{
    #region AdminConfigMenuViewModel
    /// <summary>
    /// AdminConfigMenuViewModel object derived from the <see cref="MenuViewModel"/> object.
    /// Administration role configure menu view model
    //  Used as view model for view that appears as an item in a menu
    /// </summary>
    public class AdminConfigMenuViewModel : MenuViewModel
    {


        #region Constructor
        /// <summary>
        /// AdminConfigMenuViewModel default constructor
        /// used to initialize base menu accessor properties
        /// </summary>
        public AdminConfigMenuViewModel()
        {

            Header = XPubResource.AdminConfigMenuItenDisplay;
            DisplayMemberPath = XPubResource.DisplayMemberPath;
            NavigationPath = XPubResource.AdminConfigNavigationPath;
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


    }
    #endregion

}
