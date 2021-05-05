using DevExpress.Xpf.Editors;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using XPub.Infrastructure.ViewModels;

namespace XPub.Infrastructure.Views
{
    /// <summary>
    /// Interaction logic for CreateRecordPopUp.xaml
    /// </summary>
    public partial class CreateJobPop : UserControl
    {
        public CreateJobPop()
        {
            DataContext = new CreateJobPopViewModel();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                ((PopupBaseEdit)BaseEdit.GetOwnerEdit(this)).ClosePopup();
            
        }
    }
}
