using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using System;
using System.Windows.Media;
using XPub.Interfaces;

namespace XPub.Infrastructure.Modules
{
    // <summary>
    /// XPubModuleInfo object derived from the <see cref="IXPubModuleInfo"/> interface
    /// Used as the navigation module for with a XPub view
    /// </summary>
    public class XPubModuleInfo : IXPubModuleInfo
    {


        #region Fields
        /// <summary>
        /// parent field
        /// Reference to parent services collection
        /// </summary>
        /// <value> ISupportServices reference</value>
        ISupportServices parent;
        #endregion

        #region Constructors
        /// <summary>
        /// XPubModuleInfo parametrized constructor
        /// </summary>
        /// <param name="_type">Type of module</param>
        /// <param name="parent">Parent services</param>
        /// <param name="_title">Title</param>
        public XPubModuleInfo(string _type, object parent, string _title)
        {
            Type = _type;
            this.parent = (ISupportServices)parent;
            Title = _title;
        }
        #endregion

        #region Property Accessors
        ///  <summary>
        /// Type Get  / Set Accessor
        /// Specifies the type of module
        /// </summary>
        /// <value>string</value>
        public string Type { get; private set; }

        ///  <summary>
        /// IsSelected Get  / Set Accessor
        /// Specifies if the module is selected
        /// </summary>
        /// <value> boolean</value>
        public virtual bool IsSelected { get; set; }

        ///  <summary>
        /// Title Get  / Set Accessor
        /// Specifies the module string
        /// </summary>
        /// <value>string</value>
        public string Title { get; private set; }

        ///  <summary>
        /// ImageSource Get  / Set Accessor
        /// Specifies image source object for displaying the task's icon
        /// </summary>
        /// <value>string</value>
        public virtual ImageSource Icon { get; set; }
        #endregion

        #region Utility Methods
        /// <summary>
        /// SetIcon method
        ///  Create a new Uri for the task's icon based on the Icon input parameter string
        /// </summary>
        /// <param name="icon">Icon string name</param>
        /// <returns>XPubModuleInfo</returns>
        /// <remarks> pack format may have to be changed to site of origin in order for Uri to work properly</remarks>
        public XPubModuleInfo SetIcon(string icon)
        {
            var extension = new SvgImageSourceExtension() { Uri = new Uri(string.Format(@"pack://siteoforigin:,,,/Images/{0}.svg", icon), UriKind.RelativeOrAbsolute) };
            this.Icon = (ImageSource)extension.ProvideValue(null);
            return this;
        }

        /// <summary>
        /// Show method
        /// Navigates to the corresponding  navigation frame using the navigation service
        /// </summary>
        /// <param name="parameter">Navigaion information</param>
        public void Show(object parameter = null)
        {
            INavigationService navigationService = parent.ServiceContainer.GetRequiredService<INavigationService>();
            navigationService.Navigate(Type, parameter, parent);
        }
        #endregion
    }

}
