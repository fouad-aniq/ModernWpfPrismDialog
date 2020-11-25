using ModernWpfPrismDialog.Core;
using Prism.Services.Dialogs;

namespace ModuleA.ViewModels
{
    public class DialogCViewModel : MyDialogAware
    {
        private string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }
        public DialogCViewModel()
        {
            Title = "Welcom to Dialog C";
            Message = "Hello world. this is dialog c. opened with prism mvvm....";
        }
    }
}
