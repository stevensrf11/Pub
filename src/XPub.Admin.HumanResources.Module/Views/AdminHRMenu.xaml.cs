using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Accordion;
using XPub.Infrastructure;

namespace XPub.Admin.HumanResources.Module.Views
{
    /// <summary>
    /// Interaction logic for AdminConfigMenu.xaml
    /// </summary>
    public partial class AdminHRMenu : AccordionItem, IAccordionRootItem
    {

        public AdminHRMenu()
        {
            InitializeComponent();
        }
        public string DefaultNavigationPath => nameof(AdminEmployees);
    }
}
