using DevExpress.Xpf.Accordion;
using XPub.Infrastructure;
namespace XPub.Supervisor.Configuration.Module.Views
{

    /// Interaction logic for SupervisorConfigMenu.xaml
    /// </summary>
    public partial class SupervisorConfigMenu : AccordionItem
        , IAccordionRootItem
    {

        public SupervisorConfigMenu()
        {
            InitializeComponent();
        }
        public string DefaultNavigationPath => nameof(ViewA);
    }
}
