using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WPF___MVVM.Core.Commands
{
    /// <summary>
    /// Main class for store event handling on client side, instead of code behind handling.
    /// </summary>
    class RelayCommand : ICommand
    {
        private Action _action;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public RelayCommand(Action action)
        {
            _action = action;
            _canExecute = () => true;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute != null && _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            _action.Invoke();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
