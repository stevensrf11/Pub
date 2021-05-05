using DevExpress.Xpf.Core;
using System.Windows.Controls;
using System.Windows;
using DevExpress.Xpf.RichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.API.Layout;
using System;
namespace XPub.Supervisor.JobManagement.Module.Views
{
    /// <summary>
    /// Interaction logic for SupervisorJobManagement.xaml
    /// </summary>
    public partial class SupervisorJobManagement : UserControl
    {
        RichEditControl rc;
        public SupervisorJobManagement()
        {
            ThemeManager.SetThemeName(this, "Office2019DarkGray");

            InitializeComponent();
           
            //PART_Editor.Loaded += PART_Editor_Loaded;
        }

        private void PART_Editor_Loaded(object sender, RoutedEventArgs e)
        {
            rc = sender as RichEditControl;
            //var oldUnit = rc.LayoutUnit;
            //System.Drawing.Rectangle rect = rc.GetBoundsFromPosition(rc.Document.CreatePosition(rc.Document.Range.End.ToInt() - 1));
            //System.Drawing.Rectangle rectPix = DevExpress.Office.Utils.Units.DocumentsToPixels(rect,
            //    rc.DpiX, rc.DpiY);
            //int height = rectPix.Bottom;
 
            //this.Dispatcher.BeginInvoke(new Action(() => AnonymousMethod1(sender)), System.Windows.Threading.DispatcherPriority.Render);

        }

        private void RichEditControl_ContentChanged(object sender, EventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() => AnonymousMethod1(sender)), System.Windows.Threading.DispatcherPriority.Render);
        }
        private bool AnonymousMethod1(object sender)
        {
            RichEditControl edit = rc; /*sender as RichEditControl;*/
            Document currentDocument = edit.Document;
            DocumentLayout currentDocumentLayout = edit.DocumentLayout;

            edit.BeginInvoke(() =>
            {
                double height = 0;
                System.Drawing.Size pageSize = PageLayoutHelper.GetCurrentPageSize(currentDocumentLayout);
                height = DevExpress.Office.Utils.Units.TwipsToPixels(pageSize.Height, edit.DpiY);

                edit.Height = height + 10;
                edit.VerticalScrollValue = 0;

            });
            return true;
        }
    }
    public sealed class PageLayoutHelper
    {
        private PageLayoutHelper() { }
        public static System.Drawing.Size GetCurrentPageSize(DocumentLayout currentDocumentLayout)
        {
            int totalPagesHeight = 0;
            LayoutPage firstPage = currentDocumentLayout.GetPage(0);
            int totalPageCount = currentDocumentLayout.GetFormattedPageCount();
            for (var pageIndex = 0; pageIndex < totalPageCount; pageIndex++)
            {
                LayoutPage currentPage = currentDocumentLayout.GetPage(pageIndex);
                totalPagesHeight = totalPagesHeight + currentPage.Bounds.Height;
            }
            return new System.Drawing.Size(firstPage.Bounds.Width, totalPagesHeight);
        }

    }
}
