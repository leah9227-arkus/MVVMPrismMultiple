using MVVMPrismP2.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace MVVMPrismP2.ViewModels
{
    public class UsersViewModel : BindableBase
    {
        #region Events
        private readonly IEventAggregator _eventAggregator;
        #endregion

        #region Encapsulation
        private int _Id = 0;
        public int Id {
            get => _Id;
            set => SetProperty(ref _Id, value);
        }


        private string _name = string.Empty;
        public string Name {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _lastName = string.Empty;
        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }

        private string _email = string.Empty;
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }
        #endregion

        #region Commands
        public DelegateCommand ClearInfoCommand { get; set; }
        #endregion

        #region Actions
        private void ClearInfo()
        {
            _eventAggregator.GetEvent<UserCleared>().Publish(new Models.User()
            {
                Email = _email,
                Id = _Id,
                LastName = _lastName,
                Name = _name
            });

            Id = 0;
            Name = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }
        #endregion

        public UsersViewModel(IEventAggregator eventAggregator)
        {
            ClearInfoCommand = new DelegateCommand(ClearInfo);
            _eventAggregator = eventAggregator;
        }
    }
}
