using System.Collections.ObjectModel;

namespace XPub.Infrastructure
{
    /// <summary>
    /// NavigationItem object derived from the <see cref="INavigationItem"/> object
    /// Specifies the Navigation information item used for navigation
    /// </summary>
    public class NavigationItem : INavigationItem
    {
        #region Property Accessors
        /// <summary>
        /// Header Property Get Set Accessor
        /// Caption of navigation item
        /// </summary>
        /// <value>string </value>
        /// <remarks>
        /// When used for accordion control the Header property sets the
        /// DisplayMemberPath and Root Level of an accordion item
        /// </remarks>
        public string Header { get; set; } // ?? Caption { get; set; }

        /// <summary>
        /// NavigationPath Property Get Set Accessor
        /// Path to navigate to
        /// </summary>
        /// <value>string </value>
        public string NavigationPath { get; set; }

        /// <summary>
        /// IsExpanded Property Get Set Accessor
        /// Specifies if the Navigation item is expanded of collapsed
        /// </summary>
        /// <value>string </value>
        public bool IsExpanded { get; set; }

        /// <summary>
        /// Items Property Get Set Accessor
        /// Collection of navigation items used as sub-items
        /// </summary>
        /// <value>collection of Navigation Items </value>
        public ObservableCollection<NavigationItem> Items { get; set; }
        #endregion
        #region Constructors
        /// <summary>
        /// NavigationItem default constructor
        /// Create a new NavigationItem collection object, and
        /// initializes the IsExpanded property to true
        /// </summary>
        public NavigationItem()
        {
            IsExpanded = true;
            Items = new ObservableCollection<NavigationItem>();
        }
        #endregion

  
    }

    /*

         */
}
