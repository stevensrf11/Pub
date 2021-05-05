using DevExpress.Xpf.Core;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace XPub.App.Core.RegionAdapters
{

    /// <summary>
    /// DxThemedWindowRegionAdapter object derived from the <see cref="RegionAdapterBase"/> template
    /// AccordionControl oject.
    /// Used as the region adapter for Devexpress ThemedWindow
    /// </summary>  
    /// <remarks>
    /// Could not get it to worl
    /// </remarks>
    public class DxThemedWindowRegionAdapter : RegionAdapterBase<ThemedWindow>
    {
        #region Constructors
        /// <summary>
        /// Parameterizex constructor with a single parameter
        /// </summary>
        /// <param name="regionBehaviorFactory">Interface for RegionBehaviorFactorie for reisterng region behaviors</param>
        public DxThemedWindowRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory)
            : base(regionBehaviorFactory)
        {
        }
        #endregion

        #region RegionAdapterBase Implmentation

        /// <summary>
        /// Adapts a <see cref="ThemedWindow"/> to an <see cref="IRegion"/>.
        /// </summary>
        /// <param name="region">The new region being used.</param>
        /// <param name="regionTarget">The object to adapt.</param>
        protected override void Adapt(IRegion region, ThemedWindow regionTarget)
        {
            if (regionTarget == null) throw new ArgumentNullException("regionTarget");
            bool contentIsSet = regionTarget.Content != null;
            contentIsSet = contentIsSet || (BindingOperations.GetBinding(regionTarget, ThemedWindow.ContentProperty) != null);

            if (contentIsSet)
            {
                throw new InvalidOperationException("ContentControlHasContentException");
            }

            region.ActiveViews.CollectionChanged += delegate
            {
                regionTarget.Content = region.ActiveViews.FirstOrDefault();
            };

            region.Views.CollectionChanged +=
                (sender, e) =>
                {
                    if (e.Action == NotifyCollectionChangedAction.Add && region.ActiveViews.Count() == 0)
                    {
                        region.Activate(e.NewItems[0]);
                    }
                };
        }

        /// <summary>
        /// CreateRegion method
        /// Creats the region needed for the single view.  . 
        /// </summary>
        /// <returns>SingleActiveRegion</returns>
        protected override IRegion CreateRegion()
        {
            //??new AllActiveRegion()
            return new SingleActiveRegion();
        }
        #endregion
    }
}
