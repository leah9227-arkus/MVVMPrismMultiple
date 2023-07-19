using System;
using System.Windows;
using System.Windows.Input;
using WPF___MVVM.Core;
using WPF___MVVM.Core.Commands;
using WPF___MVVM.Models;

namespace WPF___MVVM.ViewModels
{
    public class PersonViewModel : IViewModelBase
    {
        private PersonCollection _personCollection = new PersonCollection();

        public PersonCollection PersonCollection {
            get => _personCollection;
            set
            {
                _personCollection = value;
                if (value != null && value.Count > 0)
                    CurrentPerson = value[0];
                RaisePropertyChanged("PersonCollection");
            }
        }

        private Person _currentPerson;
        public Person CurrentPerson {
            get => _currentPerson;
            set
            {
                _currentPerson = value;
                RaisePropertyChanged("CurrentPerson");
                RaisePropertyChanged("CanShowInfo");
            }
        }
        public PersonViewModel()
        {

        }

        #region ListPersonsCommand
        private ICommand _listPersonsCommand;
        public ICommand ListPersonsCommand
        {
            get
            {
                if (_listPersonsCommand == null)
                    _listPersonsCommand = new RelayCommand(new Action(ListPersons));

                return _listPersonsCommand;
            }
        }

        private void ListPersons()
        {
            PersonCollection = App.DbConnection.ListPersons();
        }
        #endregion

        #region ViewPersonInfoCommand
        private ICommand _viewPersonInfoCommand;
        public ICommand ViewPersonInfoCommand
        {
            get
            {
                if (_viewPersonInfoCommand == null)
                    _viewPersonInfoCommand = new RelayCommand(new Action(ViewPersonInfo), () => CanShowInfo);

                return _viewPersonInfoCommand;
            }
        }

        private bool CanShowInfo
        {
            get => CurrentPerson != null;
        }

        

        private void ViewPersonInfo()
        {
            MessageBox.Show($"Info from {CurrentPerson.Name}!");
        }
        #endregion

        #region ViewPersonInfoUnselectedCommand
        private ICommand _viewPersonInfoUnselectedCommand;
        public ICommand ViewPersonInfoUnselectedCommand
        {
            get
            {
                if (_viewPersonInfoUnselectedCommand == null)
                    _viewPersonInfoUnselectedCommand = new ParamCommand(new Action<object>(ViewPersonInfoUnselected));

                return _viewPersonInfoUnselectedCommand;
            }
        }

        private void ViewPersonInfoUnselected(object obj)
        {
            if (obj != null)
            {
                Person p = (Person)obj;
                CurrentPerson = p;
                MessageBox.Show($"Info from {p.Name}!");

            }
        }
        #endregion

        #region DeletePersonCommand
        private ICommand _deletePersonCommand;
        public ICommand DeletePersonCommand
        {
            get
            {
                if (_deletePersonCommand == null)
                    _deletePersonCommand = new ParamCommand(new Action<object>(DeletePerson));

                return _deletePersonCommand;
            }
        }

        private void DeletePerson(object obj)
        {
            if (obj != null)
            {
                Person person = (Person)obj;
                CurrentPerson = person;

                if (App.DbConnection.DeletePerson(person))
                {
                    MessageBox.Show($"Removing {person.Name}!");
                    PersonCollection.Remove(person);
                }
            }
        }
        #endregion
    }
}
