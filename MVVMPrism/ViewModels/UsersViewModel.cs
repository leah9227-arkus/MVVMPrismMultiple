using Prism.Mvvm;
using Prism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMPrism.Models;
using Prism.Commands;
using MVVMPrism.Repository;
using System.Windows;
using Prism.Events;
using MVVMPrism.Events;

namespace MVVMPrism.ViewModels
{
    public class UsersViewModel : BindableBase
    {
        private readonly IRepositoryModels<User> _userRepository;

        #region Encapsulation
        private int _userId;
        public int UserId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        private string _email;
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private List<User> _userList;
        public List<User> UserList {
            get => _userList;
            set => SetProperty(ref _userList, value);
        }

        private User _selectedUser;
        public User SelectedUser
        {
            get => _selectedUser;
            set => SetProperty(ref _selectedUser, value, LoadSelectedUserData);
        }
        #endregion

        #region Commands
        public DelegateCommand InsertUserCommand { get; set; }
        public DelegateCommand UpdateUserCommand { get; set; }
        public DelegateCommand DeleteUserCommand { get; set; }
        public DelegateCommand LoadUserListCommand { get; set; }
        #endregion

        #region Actions
        private void InsertUser()
        {
            var response = _userRepository.Insert(new User()
            {
                Email = Email,
                Password = Password,
                UserName = UserName
            });

            var message = response ? "Tochido" : "Nelson, no se armo";

            LoadUserList();
            // not really recommended because unit testing
            MessageBox.Show(message);
        }

        private void UpdateUser()
        {
            var response = _userRepository.Update(new User()
            {
                UserId = UserId,
                Email = Email,
                Password = Password,
                UserName = UserName
            });

            _eventAggregator.GetEvent<UpdateUserEvent>().Publish($"User updated! {UserName}");

            var message = response ? "Tochido" : "Nelson, no se armo";

            LoadUserList();
            // not really recommended because unit testing
            MessageBox.Show(message);
        }

        private void DeleteUser()
        {
            var response = _userRepository.Delete(new User()
            {
                UserId = UserId,
                Email = Email,
                Password = Password,
                UserName = UserName
            });

            var message = response ? "Tochido" : "Nelson, no se armo";

            LoadUserList();
            // not really recommended because unit testing
            MessageBox.Show(message);
        }

        private void LoadUserList()
        {
            UserList = _userRepository.GetAllData();
        }

        private void LoadSelectedUserData()
        {
            UserName = SelectedUser.UserName;
            UserId = SelectedUser.UserId;
            Password = SelectedUser.Password;
            Email = SelectedUser.Email;
        }
        #endregion

        #region Events
        private IEventAggregator _eventAggregator;
        #endregion

        public UsersViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _userRepository = new UserRepository();

            InsertUserCommand = new DelegateCommand(InsertUser);
            UpdateUserCommand = new DelegateCommand(UpdateUser);
            DeleteUserCommand = new DelegateCommand(DeleteUser);
            LoadUserListCommand = new DelegateCommand(LoadUserList);

            LoadUserList();
        }

    }
}
