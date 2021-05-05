using XPub.Infrastructure.ViewModels;
using XPub.Resources;
namespace XPub.Employee.AssignedWork.Module.ViewModels
{
    /// <summary>
    /// EmployeeAssignedWorkMenuViewModel object derived from the <see cref="MenuViewModel"/> class
    /// This class served at the view model menu item for the employee assigned work screen
    /// </summary>
    public class EmployeeAssignedWorkMenuViewModel : MenuViewModel
    {
  


        #region Constructor

        public EmployeeAssignedWorkMenuViewModel()
        {
            /// <summary>
            /// EmployeeAssignedWorkMenuViewModel default constructor
            /// used to initialize base menu accessor properties
            /// </summary>
            Header = XPubResource.EmployeeAssignedWorkMenuItemDisplay;
            DisplayMemberPath = XPubResource.DisplayMemberPath;
            NavigationPath = XPubResource.EmployeeAssignedWorkNavigationPath;
            ImageUri = @"Images/Task.svg";
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
}
