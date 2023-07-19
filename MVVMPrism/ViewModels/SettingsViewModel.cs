using Prism.Mvvm;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMPrism.Events;

namespace MVVMPrism.ViewModels
{
    class SettingsViewModel : BindableBase
    {
        private string _message = "No messages.";
        public string Message {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public SettingsViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<UpdateUserEvent>().Subscribe(HandleUpdateUserEvent);
        }

        private void HandleUpdateUserEvent(string message)
        {
            Message = message;
        }
    }
}
