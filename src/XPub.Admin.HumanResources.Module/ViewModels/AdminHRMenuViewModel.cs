using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Prism.Mvvm;
using XPub.Admin.HumanResources.Module.Views;
using XPub.Infrastructure;
using XPub.Resources;

namespace XPub.Admin.HumanResources.Module.ViewModels
{
    /// <summary>
    /// AdminHRMenuViewModel object derived from the <see cref="XPubViewModelBase"/> object,
    /// and the <seealso cref="INavigationItem"/> interface
    /// Administration role employee management menu view model
    ///  Used as view model for view that appears as an item in a menu
    /// </summary>
    /// <remarks> Class is not derived from objects that AdminConfigMenuViewModel is</remarks>
    public class AdminHRMenuViewModel : XPubViewModelBase
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
            set { SetProperty(ref _displayMemberPath, value, XPubResource.PropDisplayMemberPath); }
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
        /// <summary>
        /// AdminHRMenuViewModel default constructor
        /// used to initialize base menu accessor properties
        /// </summary>
        public AdminHRMenuViewModel()
        {

            Header = XPubResource.AdminHRMenuItenDisplay;
            DisplayMemberPath = XPubResource.DisplayMemberPath;
            NavigationPath = XPubResource.AdminHRNavigationPath;
            ImageUri = @"Images/HumanResources.svg";
           
        }
        #endregion

       
    }
}
