using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;

namespace PrismDemoPluralSight.Dialogs
{
    public class MessageDialogViewModel : BindableBase, IDialogAware
    {
        private string _message = "";

        public event Action<IDialogResult> RequestClose;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public DelegateCommand CloseDialogCommand { get; private set; }

        public string Title => "My Message Dialog";

        private void CloseDialog()
        {
            var result = ButtonResult.OK;

            var p = new DialogParameters();
            p.Add("myParam", "The dialog was closed by the user.");

            RequestClose?.Invoke(new DialogResult(result, p));
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }

        public MessageDialogViewModel()
        {
            CloseDialogCommand = new DelegateCommand(CloseDialog);
        }
    }
}
