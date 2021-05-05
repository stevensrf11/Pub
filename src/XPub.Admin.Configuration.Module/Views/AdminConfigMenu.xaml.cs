using DevExpress.Xpf.Accordion;
using XPub.Infrastructure;

namespace XPub.Admin.Configuration.Module.Views
{
    /// <summary>
    /// Interaction logic for AdminConfigMenu.xaml
    /// </summary>
    public partial class AdminConfigMenu : AccordionItem, IAccordionRootItem
    {

        public AdminConfigMenu()
        {
            InitializeComponent();
        }
        public string DefaultNavigationPath => nameof(ViewA);
    }
}
