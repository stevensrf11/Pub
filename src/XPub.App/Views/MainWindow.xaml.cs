using System.Windows;
using DevExpress.Xpf.Accordion;
using DevExpress.Xpf.Core;
using XPub.Infrastructure;
using XPub.Infrastructure.Commands;

namespace XPub.App.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        #region #Fields
        /// <summary>
        /// Applicationcommands reference
        /// </summary>
        /// <value>IApplicationCommands</value>
        private readonly IApplicationCommands _applicationCommands;
        #endregion

        #region Constructors
        /// <summary>
        /// MainWindow's parameterized constructor 
        /// </summary>
        /// <param name="applicationCommands"></param>
        public MainWindow(IApplicationCommands applicationCommands)
        {
            _applicationCommands = applicationCommands;
            InitializeComponent();
        }

        #endregion

        #region Event Handler
        /// <summary>
        /// AccordionControl_OnSelectedItemChanged SelectedItemChanged event handler
        /// Called when root or sub-item selected on the accordion
        /// Can be used perform navigation because Accordion sub items to have a Command property to bind to
        /// </summary>
        /// <param name="sender">Accordion</param>
        /// <param name="e">SelectedItemChanged event handler arguments</param>
        private void AccordionControl_OnSelectedItemChanged(object sender, AccordionSelectedItemChangedEventArgs e)
        {
            if (((AccordionControl)sender).SelectedItem is NavigationItem child)
            {
                if (!string.IsNullOrEmpty(child.NavigationPath))
                {
                    CompositeCommands.NavigateCommand.Execute(child.NavigationPath);
                }
            }
        }

        #endregion

    }
}
