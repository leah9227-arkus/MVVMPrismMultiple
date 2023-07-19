using MVVMPrismP2.Events;
using MVVMPrismP2.Models;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPrismP2.ViewModels
{
    public class AccountsViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;

        private string _message = "No message.";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        private string _id = string.Empty;
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }


        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public AccountsViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<UserCleared>().Subscribe(HandleUserClearedSubscription);
        }

        public void HandleUserClearedSubscription(User user)
        {
            Message = $"Notification {user.ToString()}";
        }
    }
}
