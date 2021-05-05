using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using DevExpress.Xpf.Accordion;
using XPub.Infrastructure;

namespace XPub.Supervisor.JobManagement.Module.Views
{
    /// <summary>
    /// Interaction logic for SupervisorJobManagementMenu.xaml
    /// </summary>
    public partial class SupervisorJobManagementMenu : AccordionItem
        , IAccordionRootItem
    {
        public SupervisorJobManagementMenu()
        {
            InitializeComponent();
        }
        public string DefaultNavigationPath => nameof(ViewA);

    }
}
