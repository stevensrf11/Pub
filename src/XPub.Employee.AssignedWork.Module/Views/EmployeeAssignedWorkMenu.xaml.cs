using DevExpress.Xpf.Accordion;
using XPub.Infrastructure;

namespace XPub.Employee.AssignedWork.Module.Views
{
    /// <summary>
    /// Interaction logic for EmployeeAssignedWorkMenu.xaml
    /// </summary>
    public partial class EmployeeAssignedWorkMenu : AccordionItem
        , IAccordionRootItem
    {
        public EmployeeAssignedWorkMenu()
        {
            InitializeComponent();
        }
        public string DefaultNavigationPath => nameof(ViewA);
    }
}
