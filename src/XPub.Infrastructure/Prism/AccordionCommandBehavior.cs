using DevExpress.Xpf.Accordion;
using Prism.Interactivity;
using System.Windows;

namespace XPub.Infrastructure.Prism
{

    ///  <summary>
    /// AccordionCommandBehavior object derived from the <see cref="CommandBehaviorBase"/> object type AccordionItem
    /// A PRISM custom command behavior for the AccordionItem  Selected event to execute a command
    /// </summary>
    public class AccordionCommandBehavior : CommandBehaviorBase<AccordionItem>
    {
        #region Constructor
        /// <summary>
        /// AccordionCommandBehavior parameterized constructor
        /// Registers for the AccordionItem's Selected event
        /// </summary>
        /// <param name="acoorionItem">AccordionItem control</param>        
        public AccordionCommandBehavior(AccordionItem acoorionItem)
            : base(acoorionItem)
        {
            acoorionItem.Selected += Item_Selected;
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// Item_Selected event handler
        /// Event handler for the AccordionItem's Selected event
        /// Executes a command for the Selected event
        /// </summary>
        /// <param name="sender">AccordionItem</param>
        /// <param name="e">Selected event arguments</param>
        void Item_Selected(object sender, RoutedEventArgs e)
        {
            AccordionItem newSelectedItem = e.Source as AccordionItem;
            if (newSelectedItem.DataContext is INavigationItem param)
                CommandParameter = param.NavigationPath;
            else
                CommandParameter = string.Empty;

            ExecuteCommand(CommandParameter);
        }    
        #endregion

    }
}

