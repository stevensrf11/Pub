using Prism.Mvvm;

namespace XPub.Supervisor.Configuration.Module.ViewModels
{
    // Needs to be deleted along with the corresponding view
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
