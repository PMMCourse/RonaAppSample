using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RonaApp.ViewModel.Base
{
    public class RelayCommand : ICommand
    {
        private Action _actionToExecute;
        public RelayCommand(Action actionToExecute)
        {
            _actionToExecute = actionToExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _actionToExecute?.Invoke();
        
        }
    }

    public class RelayCommand<T> : ICommand
    {
        private Action<T> _actionToExecute;
        public RelayCommand(Action<T> actionToExecute)
        {
            _actionToExecute = actionToExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _actionToExecute.Invoke((T)parameter);
        }
    }


}
