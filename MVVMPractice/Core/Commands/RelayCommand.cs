using System;
using System.Windows.Input;

namespace MVVMPractice.Core.Commands
{
    class RelayCommand : ICommand
    {
        private Action _action;
        private Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Constructor that allows always execute commands.
        /// </summary>
        /// <param name="action"></param>
        public RelayCommand(Action action)
        {
            _action = action;
            _canExecute = () => true;
        }

        /// <summary>
        /// Constructor with restriction on can execute command.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="canExecute"></param>
        public RelayCommand(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                _action.Invoke();
            }
        }
    }
}
