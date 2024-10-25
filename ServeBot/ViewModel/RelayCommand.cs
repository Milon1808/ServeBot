using System;
using System.Windows.Input;

namespace ServeBot.ViewModel
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true; // Command ist immer ausführbar
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
