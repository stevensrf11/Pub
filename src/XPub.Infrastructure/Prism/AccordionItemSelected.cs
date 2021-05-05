using DevExpress.Xpf.Accordion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace XPub.Infrastructure.Prism
{
    ///  <summary>
    /// AccordionItemSelected object
    /// Represent the AccordionItemSelected Command object used fore executing a command
    /// against the AccordionItem Select event
    /// </summary>
    public class AccordionItemSelected
    {
        #region Dependency Properties 
        /// <summary>
        /// CommandProperty Attached Dependency Property
        /// Represents the command parameter to be sent for a command to b
        /// </summary>
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.RegisterAttached("CommandParameter",
                typeof(object), typeof(AccordionItemSelected),
                new PropertyMetadata(OnSetCommandParameterCallback));      
        
        /// <summary>
        /// SelectedCommandBehaviorProperty Attached Dependency Property
        /// Represents object the command is for
        /// </summary>
        private static readonly DependencyProperty SelectedCommandBehaviorProperty =      
            DependencyProperty.RegisterAttached("SelectedCommandBehavior",
          typeof(AccordionCommandBehavior),
          typeof(AccordionItemSelected), null);

        /// <summary>
        /// CommandProperty Attached Dependency Property
        /// Represents the command  to be executed
        /// </summary>
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached("Command",
                typeof(ICommand),
                typeof(AccordionItemSelected),
                new PropertyMetadata(OnSetCommandCallback));

        #endregion

        #region Property Accessors
        /// <summary>
        /// GetCommand Get Property Accessor
        ///  CommandProperty DP Get Accessor
        /// </summary>
        /// <param name="menuItem">AccordingItem object</param>
        /// <returns>ICommand</returns>
        public static ICommand GetCommand(AccordionItem menuItem)
        {
            return menuItem.GetValue(CommandProperty) as ICommand;
        }

        /// <summary>
        /// SetCommand Set Property Accessor
        ///  CommandProperty DP Set Accessor
        /// </summary>
        /// <param name="menuItem">AccordionItem to set the command parameter on</param>
        /// <param name="command">Command</param>
        public static void SetCommand(AccordionItem menuItem, ICommand command)
        {
            menuItem.SetValue(CommandProperty, command);
        }

        /// <summary>
        /// GetCommandParameter Get Property Accessor
        ///  CommandParameterProperty DP Get Accessor
        /// </summary>
        /// <param name="menuItem">AccordingItem object</param>
        /// <returns>object</returns>
        public static object GetCommandParameter(AccordionItem menuItem)
        {
            return menuItem.GetValue(CommandParameterProperty);
        }
        /// <summary>
        /// SetCommandParameter Set Property Accessor
        ///  CommandProperty DP Set Accessor
        /// </summary>
        /// <param name="menuItem">AccordionItem to set the parameter on</param>
        /// <param name="command">Command parameter</param>
        public static void SetCommandParameter(AccordionItem menuItem, object parameter)
        {
            menuItem.SetValue(CommandParameterProperty, parameter);
        }
        #endregion


        #region Event Handlers

        /// <summary>
        /// OnSetCommandCallback event handler 
        /// CommandProperty's DP PropertyChanged event handler
        /// Called when the property is changed
        /// Used to wire up the Command to the AccordionItem
        /// </summary>
        /// <param name="dependencyObject">Object property is called on</param>
        /// <param name="e">Event argument information</param>
        private static void OnSetCommandCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            AccordionItem menuItem = dependencyObject as AccordionItem;
            if (menuItem != null)
            {
                AccordionCommandBehavior behavior = GetOrCreateBehavior(menuItem);
                behavior.Command = e.NewValue as ICommand;
            }
        }



        /// <summary>
        /// OnSetCommandParameterCallback event handler 
        /// CommandProperty's DP PropertyChanged event handler
        /// Called when the property is changed
        /// Used to wire up the Command Parameter to the AccordionItem
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="e"></param>
        private static void OnSetCommandParameterCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            AccordionItem menuItem = dependencyObject as AccordionItem;
            if (menuItem != null)
            {
                AccordionCommandBehavior behavior = GetOrCreateBehavior(menuItem);
                behavior.CommandParameter = e.NewValue;
            }
        }
        #endregion

        #region Utility Method
        /// <summary>
        /// GetOrCreateBehavior method
        /// Used to create or use existing AccordionItem
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns></returns>
        private static AccordionCommandBehavior GetOrCreateBehavior(AccordionItem menuItem)
        {
            AccordionCommandBehavior behavior = menuItem.GetValue(SelectedCommandBehaviorProperty) as AccordionCommandBehavior;
            if (behavior == null)
            {
                behavior = new AccordionCommandBehavior(menuItem);
                menuItem.SetValue(SelectedCommandBehaviorProperty, behavior);
            }

            return behavior;
        }
            #endregion
    }
}
