using System;
using System.Collections.Specialized;
using DevExpress.Xpf.Accordion;
using Prism.Regions;

namespace XPub.App.Core.RegionAdapters
{
    /// <summary>
    ///DxAccordionControlRegionAdapter object derived from the <see cref="RegionAdapterBase"/> template
    /// AccordionControl oject.
    /// Used as the region adapter for Devexpress accprdion control
    /// </summary>
    public class DxAccordionControlRegionAdapter : RegionAdapterBase<AccordionControl>
    {
        #region Constructors
        /// <summary>
        /// Parameterizex constructor with a single parameter
        /// </summary>
        /// <param name="regionBehaviorFactory">Interface for RegionBehaviorFactorie for reisterng region behaviors</param>
        public DxAccordionControlRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory)
            : base(regionBehaviorFactory)
        {
        }
        #endregion

        #region RegionAdapterBase Implmentation

        /// <summary>
        /// Adapt
        /// </summary>
        /// <param name="region">Region for accorion control is assoicated with</param>
        /// <param name="regionTarget">Accorion Control</param>
        protected override void Adapt(IRegion region, AccordionControl regionTarget)
        {
            if (region == null)
            {
                throw new ArgumentNullException(nameof(region));
            }
            if (regionTarget == null)
            {
                throw new ArgumentNullException(nameof(regionTarget));
            }

            region.Views.CollectionChanged += (sender, args) =>
            {
                if (args.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (var view in args.NewItems)
                    {
                        AddViewToRegion(view, regionTarget);
                    }
                }
                else if (args.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (var view in args.OldItems)
                    {
                        RemoveViewFromRegion(view, regionTarget);
                    }
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

        #region Utility Methods
        /// <summary>
        /// AddViewToRegion method
        /// Used to add a single accordiom item to the accoriond controle
        /// </summary>
        /// <param name="view" >AccorionItem view</param>
        /// <param name="regionTarget">AccodionControl region</param>
        private void AddViewToRegion(object view, AccordionControl regionTarget)
        {
            if (view is AccordionItem accordionItem)
            {
                regionTarget.Items.Add(accordionItem);
                if (regionTarget.SelectedRootItem == null)
                {
                    regionTarget.SelectedRootItem = view;
                }
            }
        }

        /// <summary>
        /// RemoveViewFromRegion method
        /// Used to remove a single accordiom item to the accoriond controle
        /// </summary>
        /// <param name="view" >AccorionItem view</param>
        /// <param name="regionTarget">AccodionControl region</param>

        private void RemoveViewFromRegion(object view, AccordionControl regionTarget)
        {
            if (view is AccordionItem accordionItem)
            {
                regionTarget.Items.Remove(accordionItem);
            }
        }
        #endregion
    }

}
