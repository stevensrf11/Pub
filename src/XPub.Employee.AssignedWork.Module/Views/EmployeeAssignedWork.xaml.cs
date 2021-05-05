using DevExpress.Xpf.Core;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.WindowsUI;
using DevExpress.Xpf.WindowsUI.Navigation;
namespace XPub.Employee.AssignedWork.Module.Views
{
    /// <summary>
    /// Interaction logic for EmployeeAssignedWork.xaml
    /// </summary>
    public partial class EmployeeAssignedWork : UserControl
    {
        public EmployeeAssignedWork()
        {
            ThemeManager.SetThemeName(this, "Office2019Colorful");
            InitializeComponent();
        }
    }
}
