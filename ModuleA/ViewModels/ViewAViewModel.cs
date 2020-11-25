using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private IDialogService dialogService;

        public DelegateCommand OpenDialogBCommand { get; private set; }

        public ViewAViewModel(IDialogService _dialogService)
        {
            Message = "View A from your Prism Module";

            dialogService = _dialogService;
            OpenDialogBCommand = new DelegateCommand(OpenDialogB);
        }

        private void OpenDialogB()
        {
            var param = new DialogParameters();
            param.Add("message", "Fouad");

            dialogService.Show("DialogC", param, r =>
              {
                  if (r.Result == ButtonResult.OK)
                      Message = "Message OK";
                  else
                      Message = "Message Non OK";
              });
        }
    }
}
