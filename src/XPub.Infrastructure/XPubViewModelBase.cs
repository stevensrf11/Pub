using DevExpress.Mvvm;
using Prism.Mvvm;
using Prism.Regions;
using XPub.Interfaces.Models;
using XPub.Resources;

namespace XPub.Infrastructure
{
    /// <summary>
    /// XPubViewModelBase view model object derived from the <see cref="ViewModelBase"/> object
    /// which provides bindable notification with views, from the <seealso cref="IConfirmNavigationRequest"/>
    /// interface which provides navigations, and <seealso cref="IXPubViewModel"/> which is the base XPUV view model interface
    /// </summary>
    public class XPubViewModelBase: ViewModelBase
        , IXPubViewModel
        , IConfirmNavigationRequest
    {

        #region Fields
        private string _title;
        #endregion


        #region Property Accessors


        #region IXPubViewModel implantation
        /// <summary>
        /// Title Property GetSet Accessor
        /// Provides the title for a view
        /// </summary>
        /// <value> String</value>
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title == value)
                {
                    return;
                }
                SetProperty(ref _title, value, XPubResource.PropTitle);
            }
        }
        #endregion
        #endregion

        #region IConfirmNavigationRequest Implementation
        /// <summary>
        /// ConfirmNavigationRequest method
        /// Called in navigation to determine if navigation is allowed on the view or viewmodel 
        /// </summary>
        /// <param name="navigationContext">Navigation information object</param>
        /// <param name="continuationCallback">Action method to used in specifying if navigation allowed</param>
        public virtual void ConfirmNavigationRequest(NavigationContext navigationContext, System.Action<bool> continuationCallback)
        {
            continuationCallback(true);
        }
        #endregion

        #region INagivagateAware Implementation
        /// <summary>
        /// IsNavigationTarget method
        /// Called during navigation to determine if a  preexisting view and or view model
        /// will  be used, or a new one created when navigating to 
        /// </summary>
        /// <param name="navigationContext">Navigation information object</param>
        /// <returns>true boolean value</returns>
        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        /// <summary>
        /// OnNavigatedFrom virtual method
        /// Called during navigation on the view being navigate from
        /// </summary>
        /// <param name="navigationContext">Navigation information object</param>
        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        /// <summary>
        /// OnNavigatedTo virtual method
        /// Called during navigation on the view being navigate to
        /// </summary>
        /// <param name="navigationContext">>Navigation information object</param>
        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
        #endregion

    }
}
