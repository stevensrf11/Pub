using System.Collections.ObjectModel;
using XPub.Resources;

namespace XPub.Infrastructure.ViewModels
{
    /// <summary>
    /// MenuViewModel object derived from both the <see cref="XPubViewModelBase"/> object
    /// and the <seealso cref="INavigationItem"/> interface
    /// Serves as the base class for menu item, accordion items, and navigation item such objects
    /// </summary>
    public class MenuViewModel: XPubViewModelBase
        , INavigationItem
    {
        #region Property Accessors
        /// <summary>
        ///  Items property Get/ Set Accessor
        ///  Contains navigation subitems to navigate to
        /// </summary>
        /// <value>
        /// ObservableCollection of NavigationItem references
        /// </value>
        public ObservableCollection<NavigationItem> Items { get; set; } = new ObservableCollection<NavigationItem>();

        /// <summary>
        ///  Header property Get/ Set Accessor
        ///  
        /// </summary>
        /// <value>
        /// string
        /// </value>      
        private string _header;
        public string Header
        {
            get { return _header; }
            set { SetProperty(ref _header, value, XPubResource.PropHeader); }
        }


        /// <summary>
        ///  DisplayMemberPath property Get/ Set Accessor
        ///  
        /// </summary>
        /// <value>
        /// string
        /// </value>     
        private string _displayMemberPath;
        public string DisplayMemberPath
        {
            get { return _displayMemberPath; }
            set { SetProperty(ref _displayMemberPath, value, XPubResource.DisplayMemberPath); }
        }

        /// <summary>
        ///  NavigationPath property Get/ Set Accessor
        ///  Contains the navigation path to navigate to
        /// </summary>
        /// <value>
        /// string
        /// </value>     
        private string _navigationPath;
        public string NavigationPath
        {
            get { return _navigationPath; }
            set { SetProperty(ref _navigationPath, value, XPubResource.PropNavigationPath); }
        }


        /// <summary>
        ///  ImageUri property Get/ Set Accessor
        ///  URI string for location it image to display for menu item
        /// </summary>
        /// <value>
        /// string
        /// </value>            
        public string _imageUri;
        public string ImageUri
        {
            get { return _imageUri; }
            set { SetProperty(ref _imageUri, value, XPubResource.PropImageUri); }
        }

        #endregion

        #region Constructor

        public MenuViewModel()
        {

        }
        #endregion


    }
}
