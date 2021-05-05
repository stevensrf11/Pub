using DevExpress.Mvvm;
using DevExpress.Xpf.Printing;
namespace XPub.Infrastructure.Print
{

    public class XPubPrintViewModel : ViewModelBase
    {
        public virtual PrintableControlLink PrintableControlLink { get; set; }

        public void UpdatePrintableControlLink()
        {
            if (XPubPrintingService.PrintableControlLink != null)
            {
                PrintableControlLink = XPubPrintingService.PrintableControlLink;
                PrintableControlLink.CreateDocument(true);
            }
        }
    }
    public static class XPubPrintingService
    {
        public static PrintableControlLink PrintableControlLink;

        public static bool HasPrinting
        {
            get
            {
                return PrintableControlLink != null;
            }
        }
    }
}
